using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesSample.ViewModels;

namespace RazorPagesSample.Pages
{
    public class RegisterModel : PageModel
    {
        [BindProperty]
        public RegisterViewModel RegistrationInfo{ get; set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {

        }
    }
}