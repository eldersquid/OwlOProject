using Microsoft.EntityFrameworkCore;
using OwlOProjectA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwlOProjectA.Services
{
    public class WorkshopService
    {
        private OwloDBContext _context;
        public WorkshopService(OwloDBContext context)
        {
            _context = context;
        }
        public List<Workshop> GetAllWorkshops()
        {
            List<Workshop> AllWorkshops = new List<Workshop>();
            //AllWorkshops = _context.Workshop.Where(e => e.Published == 1).ToList();
            AllWorkshops = _context.Workshop.ToList();
            return AllWorkshops;
        }
        public List<Workshop> GetAllWorkshopsByUser(string email)
        {
            List<Workshop> AllWorkshops = new List<Workshop>();
            AllWorkshops = _context.Workshop.Where(e => e.ownerEmail == email).ToList();
            return AllWorkshops;
        }
        private bool WorkshopExists(int id)
        {
            return _context.Workshop.Any(e => e.Workshop_ID == id);
        }

        public void AddWorkshop(Workshop newWorkshop)
        {
            _context.Add(newWorkshop);
            _context.SaveChanges();
        }
        public Workshop GetWorkshopByID(int id)
        {

            Workshop workshop = _context.Workshop.Where(e => e.Workshop_ID == id).FirstOrDefault();
            return workshop;
        }

        public bool DeleteWorkshop(int id)
        {
            Workshop workshop = GetWorkshopByID(id);

            if (!WorkshopExists(workshop.Workshop_ID))
            {
                return false;
            }
            else
            {
                _context.Remove(workshop);
                _context.SaveChanges();
                return true;

            }
        }
        
        public void AddBooking(int wsid, int venid)
        {
            var currWorkshop = GetWorkshopByID(wsid);
            currWorkshop.venueID = venid;
            _context.Update(currWorkshop);
            _context.SaveChanges();
        }


        public bool UpdateWorkshop(Workshop workshop)
        {

            bool updated = true;

            //var currWorkshop = GetWorkshopByID(workshop.Workshop_ID);

            //currWorkshop.Name = workshop.Name;
            //currWorkshop.Image = workshop.Image;
            //currWorkshop.Description = workshop.Description;
            //currWorkshop.Summary = workshop.Summary;
            Console.WriteLine(workshop.ownerEmail);
            _context.Update(workshop);

            try
            {
                _context.SaveChanges();
                updated = true;

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WorkshopExists(workshop.Workshop_ID))
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
