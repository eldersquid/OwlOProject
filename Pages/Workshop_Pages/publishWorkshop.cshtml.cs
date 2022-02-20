using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OwlOProjectA.Services;

namespace OwlOProjectA.Pages.Workshop_Pages
{
    public class publishWorkshopModel : PageModel
    {

        private WorkshopService ws_svc;
        private VenueService ven_svc;
        public publishWorkshopModel(WorkshopService wsService, VenueService venService)
        {
            ws_svc = wsService;
            ven_svc = venService;
        }
        public IActionResult OnGet(int id)
        {
            var workshop = ws_svc.GetWorkshopByID(id);
            workshop.Published = 1;
            ws_svc.UpdateWorkshop(workshop);
            return Redirect("/Index");
        }
    }
}
