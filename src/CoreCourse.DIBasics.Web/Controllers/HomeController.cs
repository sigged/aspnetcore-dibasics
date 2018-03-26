using CoreCourse.DIBasics.Domain.CoffeeSystem;
using CoreCourse.DIBasics.Web.CoffeeWeb;
using CoreCourse.DIBasics.Web.Models;
using CoreCourse.DIBasics.Web.Models.Home;
using Microsoft.AspNetCore.Mvc;

namespace CoreCourse.DIBasics.Web.Controllers
{
    public class HomeController : Controller
    {
        private ICoffeeCup _coffeeCup;

        public HomeController(ICoffeeCup coffeeCup)
        {
            _coffeeCup = coffeeCup;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Coffee()
        {
            var vm = new CoffeeVm();
            ICreamer creamer = new Cream();
            ISweetener sugar = new Sugar();
            vm.CoffeeCup = new CoffeeCup(creamer, sugar);

            return View(vm);
        }

        public IActionResult CoffeeDI()
        {
            var vm = new CoffeeVm();
            vm.CoffeeCup = _coffeeCup;

            return View(vm);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel());
        }
    }
}
