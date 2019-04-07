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

        public IActionResult OnPost()
        {
            // checking if the overall object built out of multiple properties
            // follows the ModelValidations that we have specified inside the model
            if (ModelState.IsValid)
            {
                EmailService.SendEmail(Contact);
                // redirect to "Confirmation" page and triggers methods with "Contact" appendix
                return new RedirectToPageResult("Confirmation", "Contact");
            }

            // reloads current page we are on after succesfull 
            return Page();
        }

        // NOTE: event if asp-page-handler="Subscribe" but the actual method name 
        // MUST be "OnPostSubscribe(), Razor pages automatically detects the Pre-Fixes such as
        // OnGet/OnPost and combines the with the name handler we provided for the selected method
        public IActionResult OnPostSubscribe(string address)
        {
            EmailService.SendEmail(address);
            return new RedirectToPageResult("Confirmation", "Subscribe");
        }
    }
}
