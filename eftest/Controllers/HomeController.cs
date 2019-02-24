using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using eftest.Models;

namespace eftest.Controllers
{
    public class HomeController : Controller
    {
        private MyFirstDbContext shopContext;

        public HomeController(MyFirstDbContext sc)
        {
            shopContext = sc;
        }
        public IActionResult Index()
        {
            //var test = new Restaurant() { code = "testcode" , straat = "straatnaam", plaatsnaam = plaatsen.Amsterdam };
            //var test2 = new Restaurant() { code = "testcode", straat = "straatnaam", plaatsnaam = plaatsen.Rotterdam };
            //var test3 = new Restaurant() { code = "testcode", straat = "straatnaam", plaatsnaam = plaatsen.Haarlem };
            //shopContext.Add(test);
            //shopContext.Add(test2);
            //shopContext.Add(test3);
            //shopContext.SaveChanges();
            //var test2 = shopContext.Restaurants.Where(x => x.plaatsnaam == plaatsen.Rotterdam);
            //var test334 = test2.Count();
            //var z = test2.FirstOrDefault();
            //var zz = z.plaatsnaam;
            //var zzzz = z.straat;
            //var zzzzz = z.id;


            //var test3 = "string";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            string nogeentest = "nog maar een test2";
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult oudelaptoptest()
        {
            string test = "dsfsdfsdfsdfdsf";
            //v
            //v
            //v
            //v
            //v
            //v
            //v
            //v
            string pushtotestbranch = "works";
            string antohertest = "branch 2?";
            string localcommitactive = "alleen zichtbaar bij lokaal commit";
            return View();
        }



        public IActionResult nieuwelaptoptest()
        {
            string test = "dit is een test";
            string test3 = "kan het nu wel?";
            string revertstring = "dit zie ik zo niet meer";
            //c
            //c
            //c
            //c
            //c
            //c
            //c
            //c
            //c

            return View();
        }


    }
}
