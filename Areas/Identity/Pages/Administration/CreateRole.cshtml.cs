using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OwlOProjectA.Controllers;
using OwlOProjectA.Models;

namespace OwlOProjectA.Areas.Identity.Pages.Administration
{
    public class CreateRoleModel : PageModel
    {

        [BindProperty]
        public CreateRole role { get; set; }

        private AdministrationController _svc;

        public CreateRoleModel(AdministrationController admin)
        {
            _svc = admin;
        }
        public void OnGet()
        {
        }

        public void onPost()
        {
            _svc.CreateRoleAsync(role).GetAwaiter().GetResult();
        }
    }
}
