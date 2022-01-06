using Microsoft.EntityFrameworkCore;
using OwlOProjectA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwlOProjectA.Services
{
    public class VoucherService
    {
        private Models.OwloDBContext _context;
        public VoucherService(Models.OwloDBContext context)
        {
            _context = context;
        }
        public List<Voucher> GetAllVouchers()
        {
            List<Voucher> AllVouchers = new List<Voucher>();
            AllVouchers = _context.Vouchers.ToList();
            return AllVouchers;
        }
        private bool VoucherExists(string id)
        {
            return _context.Vouchers.Any(e => e.Vouchers_ID == id);
        }

        public bool AddVoucher(Voucher newVoucher)
        {
            if (VoucherExists(newVoucher.Vouchers_ID))
            {
                return false;
            }
            else
            {
                _context.Add(newVoucher);
                _context.SaveChanges();
                return true;

            }
        }
        public Voucher GetVoucherByID(String id)
        {

            Voucher voucher = _context.Vouchers.Where(e => e.Vouchers_ID == id).FirstOrDefault();
            return voucher;
        }

        public bool DeleteVoucher(Voucher voucher)
        {
            if (!VoucherExists(voucher.Vouchers_ID))
            {
                return false;
            }
            else
            {
                _context.Remove(voucher);
                _context.SaveChanges();
                return true;

            }
        }

        public bool UpdateVoucher(Voucher voucher)
        {
            bool updated = true;
            _context.Attach(voucher).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
                updated = true;

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VoucherExists(voucher.Vouchers_ID))
                {
                    updated = false;
                }
                else
                {
                    throw;
                }
            }
            return updated;


        }
    }
}
