using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OwlOProjectA.Models;
using OwlOProjectA.Services;

namespace OwlOProjectA.Pages.Workshop_Pages
{
    public class browseVenuesModel : PageModel
    {
        [BindProperty]
        public Workshop workshop { get; set; }

        [BindProperty]
        public List<Venue> allVenues { get; set; }

        private WorkshopService ws_svc;
        private VenueService ven_svc;
        public browseVenuesModel(WorkshopService wsService, VenueService venService)
        {
            ws_svc = wsService;
            ven_svc = venService;
        }
        public void OnGet(int id)
        {
            workshop = ws_svc.GetWorkshopByID(id);
            allVenues = ven_svc.GetAllVenues();
        }
    }
}
