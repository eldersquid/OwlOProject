using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OwlOProjectA.Models;
using Microsoft.EntityFrameworkCore;

namespace OwlOProjectA.Services
{
    public class OwleeService
    {
        private Models.OwloDBContext _context;
        public OwleeService(Models.OwloDBContext context)
        {
            _context = context;
        }
        public List<Owlee> GetAllOwlees()
        {
            List<Owlee> AllOwlees = new List<Owlee>();
            AllOwlees = _context.Owlees.ToList();
            return AllOwlees;
        }
        private bool OwleeExists(string email)
        {
            return _context.Owlees.Any(e => e.Email == email);
        }

        public bool AddOwlee(Owlee newOwlee)
        {
            if (OwleeExists(newOwlee.Email))
            {
                return false;
            }
            else
            {
                _context.Add(newOwlee);
                _context.SaveChanges();
                return true;
                 
            }
        }
        public Owlee GetOwleeByEmail(String email)
        {
            
            Owlee owlee = _context.Owlees.Where(e => e.Email == email).FirstOrDefault();
            return owlee;
        }

        public bool DeleteOwlee(Owlee owlee)
        {
            if (!OwleeExists(owlee.Email))
            {
                return false;
            }
            else
            {
                _context.Remove(owlee);
                _context.SaveChanges();
                return true;

            }
        }

        public bool UpdateOwlee(Owlee owlee)
        {
            bool updated = true;
            _context.Attach(owlee).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
                updated = true;

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OwleeExists(owlee.Email))
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
