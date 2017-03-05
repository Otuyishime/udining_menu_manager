using System;
using System.Collections.Generic;

namespace MenuManager.Models
{
    public enum Menu_meal:Byte { Breakfast, Lunch, Supper }

    public partial class Menu
    {
        public DateTime Menu_Date { get; set; }
        public Menu_meal Meal_Type { get; set; }

        public FoodLine Feature_Line { get; set; }
        public FoodLine Gluteen_Free_Line { get; set; }
        public FoodLine Chef_Line { get; set; }
        public FoodLine Fresh_Market_Gourmet_Sandwich { get; set; }
        public FoodLine Fresh_Market_Salads_And_Wraps { get; set; }
        public FoodLine Soup_Of_The_Day { get; set; }
    }
}
