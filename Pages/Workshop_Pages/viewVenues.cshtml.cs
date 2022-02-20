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
    public class viewVenuesModel : PageModel
    {
        [BindProperty]
        public Workshop workshop { get; set; }

        [BindProperty]
        public Venue venue { get; set; }

        private WorkshopService ws_svc;
        private VenueService ven_svc;
        public viewVenuesModel(WorkshopService wsService, VenueService venService)
        {
            ws_svc = wsService;
            ven_svc = venService;
        }
        public void OnGet(int wsid, int venid)
        {
            workshop = ws_svc.GetWorkshopByID(wsid);
            venue = ven_svc.GetVenueByID(venid);
        }
    }
}
