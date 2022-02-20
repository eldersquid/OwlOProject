using owlo_plan.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace owlo_plan.Services
{
    public class ResourceService
    {
        private OwloPlanDBContext _context;
        public ResourceService(OwloPlanDBContext context)
        {
            _context = context;
        }
        public List<Resources> GetAllResources(string project_id) {
            List<Resources> AllResources = new List<Resources>();
            AllResources = _context.Resources.Where(b => b.project_id.Contains(project_id)).ToList();
            return AllResources;
        }
        public Resources GetResource(string resourceid) {
            return _context.Resources.Where(b => b.Resource_id.Contains(resourceid)).First();
        }
        public void AddResource(Resources resource) {
            _context.Add(resource);
            _context.SaveChanges();
        }
        public void DeleteResource(string resource_id) {
            Resources resource = _context.Resources.Where(b => b.Resource_id == resource_id).First();
            _context.Remove(resource);
            _context.SaveChanges();
        }
        public void UpdateResource(Resources resources) {
            Console.WriteLine($"this is in resourceservice, {resources.title}, {resources.link}");
            Resources resource = _context.Resources.Where(b => b.Resource_id == resources.Resource_id).First();
            resource.link = resources.link;
            resource.title = resources.title;
            _context.Update(resource);
            _context.SaveChanges();
        }
    }
}
