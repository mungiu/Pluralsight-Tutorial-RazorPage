using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffee.Models;
using WiredBrainCoffee.Services;

namespace WiredBrainCoffee.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public Contact Contact { get; set; }
        public string Message { get; private set; }

        public void OnGet()
        {

        }

        public void OnPost()
        {
            // checking if the overall object built out of multiple properties
            // follows the ModelValidations that we have specified inside the model
            if (ModelState.IsValid)
            {
                EmailService.SendEmail(Contact);
                Message = "Your email has been sent";
            }
        }

        // NOTE: event if asp-page-handler="Subscribe" but the actual method name 
        // MUST be "OnPostSubscribe(), Razor pages automatically detects the Pre-Fixes such as
        // OnGet/OnPost and combines the with the name handler we provided for the selected method
        public void OnPostSubscribe(string address)
        {
            EmailService.SendEmail(address);
            Message = "You have been added to the mailing list";
        }
    }
}
