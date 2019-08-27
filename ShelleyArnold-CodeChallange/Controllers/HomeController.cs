using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShelleyArnold_CodeChallange.Models;

namespace ShelleyArnold_CodeChallange.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var view = GetPreambleResults();
            return View(view);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private Result GetPreambleResults()
        {
            var result = new Result();

            var preamble = @"We the People of the United States, 
                in Order to form a more perfect Union, establish Justice, insure domestic Tranquility, 
                provide for the common defense, promote the general Welfare, and secure the Blessings
                of Liberty to ourselves and our Posterity, do ordain and establish this Constitution for
                the United States of America.";

            var preambleWordArray = preamble.Replace(",", "").Split(" ");

            foreach(var word in preambleWordArray)
            {
                if (word.StartsWith("t", StringComparison.InvariantCultureIgnoreCase) 
                    && word.EndsWith("e", StringComparison.InvariantCultureIgnoreCase))
                {
                    result.TAndE++;
                }
                else if (word.StartsWith("t", StringComparison.InvariantCultureIgnoreCase))
                {
                    result.StartsWithT++;
                }
                else if (word.EndsWith("e", StringComparison.InvariantCultureIgnoreCase))
                {
                    result.EndsWithE++;
                }
            }

            return result;
        }
    }
}
