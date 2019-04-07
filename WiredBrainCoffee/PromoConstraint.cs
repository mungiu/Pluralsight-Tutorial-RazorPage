using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WiredBrainCoffee
{
    /// <summary>
    /// This class is used for creating custom route constraints
    /// </summary>
    public class PromoConstraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            // custom route constraints are defined below
            // these can be use to ensure to obfuscate access to a specific page

            int letterCount = 0;
            int numCount = 0;
            int sum = 0;

            //NOTE: we use "token" because that is how we manually named the token in "Feedback.cshtml" at the top of the page
            foreach (var item in values["token"].ToString())
            {
                // counting letters
                letterCount += Char.IsLetter(item) ? 1 : 0;
                // counting numbers
                numCount += Char.IsDigit(item) ? 1 : 0;
                // adding all numbers
                sum += Char.IsDigit(item) ? int.Parse(item.ToString()) : 0;
            }

            return letterCount == 3 && numCount == 3 && sum % 3 == 0;
        }
    }
}
