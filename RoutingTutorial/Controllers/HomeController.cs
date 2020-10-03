using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutingTutorial.Controllers {
    public class HomeController: Controller {
        [Route("/")]
        public IActionResult Index() {
            return Content("Home");
        }

        [Route("About")]
        public IActionResult About() {
            return Content("About");
        }

        public IActionResult Display(string id) {
            if (id == null)
                return Content("No ID supplied");
            else
                return Content("Id is " + id);
        }

        [Route("[action]/{start}/{end?}/{message?}")]
        public IActionResult Countdown(int start, int end = 0, string message = "") {
            string contentString = "Counting down:\n";
            for (int i = start; i >= end; i--) {
                contentString += i + "\n";
            }
            contentString += message;
            return Content(contentString);
        }
    }
}
