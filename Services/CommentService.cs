using Microsoft.EntityFrameworkCore;
using OwlOProjectA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace OwlOProjectA.Services
{
    public class CommentService
    {
        private OwloDBContext _context;
        public CommentService(OwloDBContext context)
        {
            _context = context;
        }

        public bool AddComment(Comment newcomment)
        {
            if (CommentExists(newcomment.Id))
            {
                return false;
            }
            _context.Comments.Add(newcomment);
            _context.SaveChanges();
            return true;
        }
        public List<Comment> GetAllComments()
        {
            List<Comment> AllComments = new List<Comment>();
            AllComments = _context.Comments.ToList();
            return AllComments;
        }
        public Comment GetCommentById(String id)
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
            Comment theComment = _context.Comments.Where(e => e.Id == id).FirstOrDefault();
            return theComment;
        }
        private bool CommentExists(string id)
        {
            return _context.Comments.Any(e => e.Id == id);
        }
       
        }

        

    }

