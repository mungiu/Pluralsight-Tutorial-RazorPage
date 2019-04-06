using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiredBrainCoffee.Models;
using WiredBrainCoffee.Services;

namespace WiredBrainCoffee.Pages
{
    public class ItemModel : PageModel
    {
        //public string Message { get; set; }
        public MenuItem Item { get; private set; }

        // .NET is smart enough to rout URL path segments as parameters
        public void OnGet(int id)
        {
            //Message = "The id is " + id;

            var menuService = new MenuService();
            Item = menuService.GetMenuItems().FirstOrDefault(x => x.Id == id);
        }
    }
}
