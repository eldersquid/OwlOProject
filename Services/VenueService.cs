using OwlOProjectA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwlOProjectA.Services
{
    public class VenueService
    {
        private OwloDBContext _context;
        public VenueService(OwloDBContext context)
        {
            _context = context;
        }
        public List<Venue> GetAllVenues()
        {
            List<Venue> AllVenues = new List<Venue>();
            AllVenues = _context.Venues.ToList();
            return AllVenues;
        }
        //public List<Workshop> GetAllWorkshopsByUser(string email)
        //{
        //    List<Workshop> AllWorkshops = new List<Workshop>();
        //    AllWorkshops = _context.Workshop.Where(e => e.ownerEmail == email).ToList();
        //    return AllWorkshops;
        //}
        public bool BookingExists(DateTime date, int venid)
        {
            return _context.Bookings.Any(e => e.venueID == venid && e.Date == date);
        }

        public void AddBooking(Booking newBooking)
        {
            _context.Add(newBooking);
            _context.SaveChanges();
        }
        public Venue GetVenueByID(int id)
        {

            Venue venue = _context.Venues.Where(e => e.Venue_ID == id).FirstOrDefault();
            return venue;
        }

        //public bool DeleteWorkshop(int id)
        //{
        //    Workshop workshop = GetWorkshopByID(id);

        //    if (!WorkshopExists(workshop.Workshop_ID))
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        _context.Remove(workshop);
        //        _context.SaveChanges();
        //        return true;

        //    }
        //}

        //public bool UpdateWorkshop(Workshop workshop)
        //{

        //    bool updated = true;

        //    //var currWorkshop = GetWorkshopByID(workshop.Workshop_ID);

        //    //currWorkshop.Name = workshop.Name;
        //    //currWorkshop.Image = workshop.Image;
        //    //currWorkshop.Description = workshop.Description;
        //    //currWorkshop.Summary = workshop.Summary;
        //    Console.WriteLine(workshop.ownerEmail);
        //    _context.Update(workshop);

        //    try
        //    {
        //        _context.SaveChanges();
        //        updated = true;

        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!WorkshopExists(workshop.Workshop_ID))
        //        {
        //            updated = false;
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }
        //    return updated;


        //}
    }
}
