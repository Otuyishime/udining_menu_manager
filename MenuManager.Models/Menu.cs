using System;
using System.Collections.Generic;

namespace MenuManager.Models
{
    public enum Menu_meal:Byte { Breakfast, Lunch, Supper }

    public partial class Menu
    {
        public DateTime Menu_date { get; set; }
        public Menu_meal Meal_type { get; set; }
        public HashSet<FoodLine> Food_lines { get; set; }
    }
}
