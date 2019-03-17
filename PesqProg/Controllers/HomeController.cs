using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PesqProg.Models;

namespace PesqProg.Controllers
{
    public class HomeController : Controller
    {

        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            ProgResponse pR = new ProgResponse();
            List<CheckboxItemProg> cbiProg = new List<CheckboxItemProg>()
            {
                new CheckboxItemProg{Id = 1, Text="Java", IsChecked = false},
                new CheckboxItemProg{Id = 2, Text="JavaScript", IsChecked = false},
                new CheckboxItemProg{Id = 3, Text="Ruby", IsChecked = false},
                new CheckboxItemProg{Id = 4, Text="Kotlin", IsChecked = false},
                new CheckboxItemProg{Id = 5, Text="Swift", IsChecked = false},
                new CheckboxItemProg{Id = 6, Text="Lua", IsChecked = false},
                new CheckboxItemProg{Id = 7, Text="PHP", IsChecked = false},
                new CheckboxItemProg{Id = 8, Text="C/C++", IsChecked = false},
                new CheckboxItemProg{Id = 9, Text="C#", IsChecked = false},
                new CheckboxItemProg{Id = 10, Text="Python", IsChecked = false},
                new CheckboxItemProg{Id = 11, Text="HTML/CSS", IsChecked = false},
                new CheckboxItemProg{Id = 12, Text="Go", IsChecked = false},
                new CheckboxItemProg{Id = 13, Text="Rust", IsChecked = false},
                new CheckboxItemProg{Id = 14, Text="Elxir", IsChecked = false},
                new CheckboxItemProg{Id = 15, Text="Haskwell", IsChecked = false},
                new CheckboxItemProg{Id = 16, Text="TypeScript", IsChecked = false},
                new CheckboxItemProg{Id = 17, Text="R", IsChecked = false},
                new CheckboxItemProg{Id = 18, Text="F#", IsChecked = false},
                new CheckboxItemProg{Id = 19, Text="Clojure", IsChecked = false},
                new CheckboxItemProg{Id = 20, Text="Erlang", IsChecked = false}
            };

            pR.ItemProgs = cbiProg;
            return View(pR);
        }

        [HttpPost]
        public ViewResult RsvpForm(ProgResponse progResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(progResponse);
                return View("Thanks", progResponse);
            }
            else
            {
                return View(progResponse);
            }
        }

        public ViewResult ListResponses()
        {
            return View(Repository.responses);
        }

        [HttpGet]
        public ActionResult MostraTrabalho()
        {
            return View("ListResponses", Repository.responses.Where(r => r.TrabalhaArea == true));
        }

        [HttpGet]
        public ActionResult MostraNaoTrabalho()
        {
            return View("ListResponses", Repository.responses.Where(r => r.TrabalhaArea == false));
        }


        /*
        public IActionResult Index()
        {
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

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        */
    }
}
