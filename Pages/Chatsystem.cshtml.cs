using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Chat.Web.Pages
{
    public class ChatsystemModel : PageModel
    {
        private readonly ILogger<ChatsystemModel> _logger;

        public ChatsystemModel(ILogger<ChatsystemModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
