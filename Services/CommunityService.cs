using Microsoft.EntityFrameworkCore;
using OwlOProjectA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwlOProjectA.Services
{
    public class CommunityService
    {
        private OwloDBContext _context;
        public CommunityService(OwloDBContext context)
        {
            _context = context;
        }

        public bool AddCommunity(Community newcommunity)
        {
            if (CommunityExists(newcommunity.Id))
            {
                return false;
            }
            _context.Communities.Add(newcommunity);
            _context.SaveChanges();
            return true;
        }
        public List<Community> GetAllCommunities()
        {
            List<Community> AllCommunities = new List<Community>();
            AllCommunities = _context.Communities.ToList();
            return AllCommunities;
        }
        public Community GetCommunityById(String id)
        {
            //List<Employee> AllEmployees = new List<Employee>();

            //Employee employee = null;
            //foreach (Employee item in AllEmployees)
            //{
            //    if (item.Id == id)
            //    {
            //        employee = item;
            //    }
            //}
            Community theCommunity = _context.Communities.Where(e => e.Id == id).FirstOrDefault();
            return theCommunity;
        }
        private bool CommunityExists(string id)
        {
            return _context.Communities.Any(e => e.Id == id);
        }
        public bool DeleteCommunity(Community community)
        {
            if (!CommunityExists(community.Id))
            {
                return false;
            }
            else
            {
                _context.Remove(community);
                _context.SaveChanges();
                return true;

            }
        }

        public bool UpdateCommunity(Community thecommunity)
        {
            bool updated = true;
            _context.Attach(thecommunity).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
                updated = true;

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommunityExists(thecommunity.Id))
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
