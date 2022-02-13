using Microsoft.EntityFrameworkCore;
using OwlOProjectA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwlOProjectA.Services
{
    public class LuckyDrawService
    {
        private Models.OwloDBContext _context;
        public LuckyDrawService(Models.OwloDBContext context)
        {
            _context = context;
        }
        public List<LuckyDraw> GetAllLuckyDraws()
        {
            List<LuckyDraw> AllLuckyDraws = new List<LuckyDraw>();
            AllLuckyDraws = _context.LuckyDraws.ToList();
            return AllLuckyDraws;
        }
        private bool LuckyDrawExists(string id)
        {
            return _context.LuckyDraws.Any(e => e.LuckyDraw_ID == id);
        }

        public bool AddLuckyDraw(LuckyDraw newLuckyDraw)
        {
            if (LuckyDrawExists(newLuckyDraw.LuckyDraw_ID))
            {
                return false;
            }
            else
            {
                _context.Add(newLuckyDraw);
                _context.SaveChanges();
                return true;

            }
        }
        public LuckyDraw GetLuckyDrawByID(String id)
        {

            LuckyDraw LuckyDraw = _context.LuckyDraws.Where(e => e.LuckyDraw_ID == id).FirstOrDefault();
            return LuckyDraw;
        }

        public bool DeleteLuckyDraw(LuckyDraw LuckyDraw)
        {
            if (!LuckyDrawExists(LuckyDraw.LuckyDraw_ID))
            {
                return false;
            }
            else
            {
                _context.Remove(LuckyDraw);
                _context.SaveChanges();
                return true;

            }
        }

        public bool UpdateLuckyDraw(LuckyDraw LuckyDraw)
        {

            bool updated = true;
            
            
            _context.Attach(LuckyDraw).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
                updated = true;

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LuckyDrawExists(LuckyDraw.LuckyDraw_ID))
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
