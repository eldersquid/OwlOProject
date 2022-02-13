using Microsoft.EntityFrameworkCore;
using OwlOProjectA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwlOProjectA.Services
{
    public class CommunityPostService
    {
        private OwloDBContext _context;
        public CommunityPostService(OwloDBContext context)
        {
            _context = context;
        }

        public bool AddCommunityPost(CommunityPost newcommunitypost)
        {
            if (CommunityPostExists(newcommunitypost.Id))
            {
                return false;
            }
            _context.CommunityPosts.Add(newcommunitypost);
            _context.SaveChanges();
            return true;
        }
        public List<CommunityPost> GetAllCommunityPosts()
        {
            List<CommunityPost> AllCommunityPosts = new List<CommunityPost>();
            AllCommunityPosts = _context.CommunityPosts.ToList();
            return AllCommunityPosts;
        }
        public CommunityPost GetCommunityPostById(String id)
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
            CommunityPost theCommunityPost = _context.CommunityPosts.Where(e => e.Id == id).FirstOrDefault();
            return theCommunityPost;
        }
        private bool CommunityPostExists(string id)
        {
            return _context.CommunityPosts.Any(e => e.Id == id);
        }
        public bool DeleteCommunityPost(CommunityPost communitypost)
        {
            if (!CommunityPostExists(communitypost.Id))
            {
                return false;
            }
            else
            {
                _context.Remove(communitypost);
                _context.SaveChanges();
                return true;

            }
        }

        public bool UpdateCommunityPost(CommunityPost thecommunitypost)
        {
            bool updated = true;
            _context.Attach(thecommunitypost).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
                updated = true;

            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommunityPostExists(thecommunitypost.Id))
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

