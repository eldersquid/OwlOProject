using Microsoft.EntityFrameworkCore;
using OwlOProjectA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwlOProjectA.Services
{
    public class VoucherDistributionService
    {
        private Models.OwloDBContext _context;
        public VoucherDistributionService(Models.OwloDBContext context)
        {
            _context = context;
        }
        public List<VoucherDistribution> GetAllVoucherDistributions()
        {
            List<VoucherDistribution> AllVoucherDistributions = new List<VoucherDistribution>();
            AllVoucherDistributions = _context.VoucherDistributions.ToList();
            return AllVoucherDistributions;
        }

        public List<VoucherDistribution> GetAllVoucherDistributionsByEmail(string email)
        {
            List<VoucherDistribution> AllVoucherDistributions = GetAllVoucherDistributions();
            List<VoucherDistribution> voucherDistributions = new List<VoucherDistribution>();
            voucherDistributions = AllVoucherDistributions.Where(v => v.VoucherDistribution_OwnerEmail == email).ToList();
            
            
            
            return voucherDistributions;
        }
        private bool VoucherDistributionExists(string id)
        {
            return _context.VoucherDistributions.Any(e => e.VoucherDistribution_ID == id);
        }

        public bool AddVoucherDistribution(VoucherDistribution newVoucherDistribution)
        {
            if (VoucherDistributionExists(newVoucherDistribution.VoucherDistribution_ID))
            {
                return false;
            }
            else
            {
                _context.Add(newVoucherDistribution);
                _context.SaveChanges();
                return true;

            }
        }
        public VoucherDistribution GetVoucherDistributionByID(String id)
        {

            VoucherDistribution VoucherDistribution = _context.VoucherDistributions.Where(e => e.VoucherDistribution_ID == id).FirstOrDefault();
            return VoucherDistribution;
        }

        public bool DeleteVoucherDistribution(VoucherDistribution VoucherDistribution)
        {
            if (!VoucherDistributionExists(VoucherDistribution.VoucherDistribution_ID))
            {
                return false;
            }
            else
            {
                _context.Remove(VoucherDistribution);
                _context.SaveChanges();
                return true;

            }
        }

        public bool UpdateVoucherDistribution(VoucherDistribution VoucherDistribution)
        {

            bool updated = true;


            _context.Attach(VoucherDistribution).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
                updated = true;

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VoucherDistributionExists(VoucherDistribution.VoucherDistribution_ID))
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
