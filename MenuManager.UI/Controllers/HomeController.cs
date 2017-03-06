using MenuManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MenuManager.UI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var empty_model = new MenuViewModel();
            empty_model.Feature_Line = new FoodLine();
            empty_model.Gluteen_Free_Line = new FoodLine();
            empty_model.Chef_Line = new FoodLine();
            empty_model.Fresh_Market_Gourmet_Sandwich = new FoodLine();
            empty_model.Fresh_Market_Salads_And_Wraps = new FoodLine();
            empty_model.Soup_Of_The_Day = new FoodLine();

            empty_model.Feature_Line.Foods = new List<Food>();
            empty_model.Gluteen_Free_Line.Foods = new List<Food>();
            empty_model.Chef_Line.Foods = new List<Food>();
            empty_model.Fresh_Market_Gourmet_Sandwich.Foods = new List<Food>();
            empty_model.Fresh_Market_Salads_And_Wraps.Foods = new List<Food>();
            empty_model.Soup_Of_The_Day.Foods = new List<Food>();


            empty_model.Feature_Line.Foods.Add(new Food());
            empty_model.Gluteen_Free_Line.Foods.Add(new Food());
            empty_model.Chef_Line.Foods.Add(new Food());
            empty_model.Fresh_Market_Gourmet_Sandwich.Foods.Add(new Food());
            empty_model.Fresh_Market_Salads_And_Wraps.Foods.Add(new Food());
            empty_model.Soup_Of_The_Day.Foods.Add(new Food());
            empty_model.Fresh_Market_Salads_And_Wraps.Foods.Add(new Food());
            empty_model.Soup_Of_The_Day.Foods.Add(new Food());

            return View(empty_model);
        }

        [HttpGet]
        public ActionResult EditMenu()
        {
            ViewBag.Message = "Your application edit menu page.";

            var model = new MenuViewModel();
            model.Feature_Line = new FoodLine { Food_line_title = "test feature" };
            model.Gluteen_Free_Line = new FoodLine { Food_line_title = "test Gluteen" };
            model.Chef_Line = new FoodLine { Food_line_title = "test Chef" };
            model.Fresh_Market_Gourmet_Sandwich = new FoodLine { Food_line_title = "test fresh sandwich" };
            model.Fresh_Market_Salads_And_Wraps = new FoodLine { Food_line_title = "test fresh salads" };
            model.Soup_Of_The_Day = new FoodLine { Food_line_title = "test fresh soup" };

            model.Feature_Line.Foods = new List<Food>();
            model.Gluteen_Free_Line.Foods = new List<Food>();
            model.Chef_Line.Foods = new List<Food>();
            model.Fresh_Market_Gourmet_Sandwich.Foods = new List<Food>();
            model.Fresh_Market_Salads_And_Wraps.Foods = new List<Food>();
            model.Soup_Of_The_Day.Foods = new List<Food>();


            model.Feature_Line.Foods.Add(new Food { Food_name = "food1" });
            model.Gluteen_Free_Line.Foods.Add(new Food { Food_name = "food2" });
            model.Chef_Line.Foods.Add(new Food { Food_name = "food3" });
            model.Fresh_Market_Gourmet_Sandwich.Foods.Add(new Food { Food_name = "food1" });
            model.Fresh_Market_Salads_And_Wraps.Foods.Add(new Food { Food_name = "food1" });
            model.Soup_Of_The_Day.Foods.Add(new Food { Food_name = "food1" });
            model.Fresh_Market_Salads_And_Wraps.Foods.Add(new Food { Food_name = "food2" });
            model.Soup_Of_The_Day.Foods.Add(new Food { Food_name = "food2" });

            return View(model);
        }

        [HttpPost]
        public ActionResult GetMenu()
        {
            ViewBag.Message = "Your application get menu page.";

            return View();
        }

        [HttpPost]
        public ActionResult PostMenu(MenuViewModel menuModel)
        {
            if (ModelState.IsValid)
            {
                var menu = menuModel;
            }

            return new RedirectResult("/Home");
        }

        [HttpPost]
        public PartialViewResult GetBlankFoodField(string item_name)
        {
            return PartialView("_FoodLineItemPartialView", new FoodViewModel { item_name = item_name });
        }
    }
}