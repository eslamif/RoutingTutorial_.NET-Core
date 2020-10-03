using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RoutingTutorial.Controllers {
    public class ProductController : Controller {
        public IActionResult List(string cat, int num) {
            return Content("Product Controller, List Action, " +
                    "Category = " + cat + ", Page = " + num);
        }

        public IActionResult Detail(int id) {
            return Content("Product Controller, Detail Action, ID = " + id);
        }
    }
}
