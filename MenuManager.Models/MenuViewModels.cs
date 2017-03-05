using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MenuManager.Models
{
    public class FoodViewModel
    {
        [StringLength(200, ErrorMessage = "The name of the food should be less than {0} characters")]
        public string Food_name { get; set; }

        public string item_name { get; set; }
    }

    public class FoodLineViewModel
    {
        [StringLength(200, ErrorMessage = "The title of the food line should be less than {0} characters")]
        public string Food_line_title { get; set; }

        public List<Food> Foods { get; set; }
    }

    public class MenuViewModel
    {
        public List<Menu_meal> Meals_types = new List<Menu_meal> {
                                                Menu_meal.Breakfast,
                                                Menu_meal.Lunch,
                                                Menu_meal.Supper };

        [DataType(DataType.DateTime, ErrorMessage = "Please provide a correct date")]
        public DateTime Menu_date { get; set; }

        public Menu_meal Meal_type { get; set; }
        public FoodLine Feature_Line { get; set; }
        public FoodLine Gluteen_Free_Line { get; set; }
        public FoodLine Chef_Line { get; set; }
        public FoodLine Fresh_Market_Gourmet_Sandwich { get; set; }
        public FoodLine Fresh_Market_Salads_And_Wraps { get; set; }
        public FoodLine Soup_Of_The_Day { get; set; }
    }
}
