using Microsoft.EntityFrameworkCore;
using OwlOProjectA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwlOProjectA.Services
{
    public class FAQService
    {
        private Models.OwloDBContext _context;
        public FAQService(Models.OwloDBContext context)
        {
            _context = context;
        }
        public List<FAQ> GetAllFAQs()
        {
            List<FAQ> AllFAQs = new List<FAQ>();
            AllFAQs = _context.FAQs.ToList();
            return AllFAQs;
        }
        private bool FAQExists(string id)
        {
            return _context.FAQs.Any(e => e.FAQ_ID == id);
        }

        public bool AddFAQ(FAQ newFAQ)
        {
            if (FAQExists(newFAQ.FAQ_ID))
            {
                return false;
            }
            else
            {
                _context.Add(newFAQ);
                _context.SaveChanges();
                return true;

            }
        }
        public FAQ GetFAQByID(String id)
        {

            FAQ FAQ = _context.FAQs.Where(e => e.FAQ_ID == id).FirstOrDefault();
            return FAQ;
        }

        public bool DeleteFAQ(FAQ FAQ)
        {
            if (!FAQExists(FAQ.FAQ_ID))
            {
                return false;
            }
            else
            {
                _context.Remove(FAQ);
                _context.SaveChanges();
                return true;

            }
        }

        public bool UpdateFAQ(FAQ FAQ)
        {

            bool updated = true;
            
            
            _context.Attach(FAQ).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
                updated = true;

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FAQExists(FAQ.FAQ_ID))
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
