using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminLTE.Core.Data;
using AdminLTE.Core.Services.Mail;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AdminLTE.Core.Pages.Settings
{
    public class AccountModel : PageModel
    {
        public AccountModel() 
        {
        }

        public IActionResult OnGet()
        {
            return Page();
        }
    }
}