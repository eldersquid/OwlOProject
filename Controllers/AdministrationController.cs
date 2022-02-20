using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OwlOProjectA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OwlOProjectA.Controllers
{
    public class AdministrationController : Controller
    {

        private readonly RoleManager<IdentityRole> roleManager;
        public AdministrationController(RoleManager<IdentityRole> roleManager)
        {
            this.roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoleAsync(CreateRole model)
        {
            
                IdentityRole identityRole = new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = model.RoleName
                };

                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToPage("Index");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        System.Diagnostics.Debug.WriteLine(error);
                    }
                return View(model);
            }
                
           

            
        }
    }
}
