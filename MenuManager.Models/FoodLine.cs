using System;
using System.Collections.Generic;

namespace MenuManager.Models
{
    public partial class FoodLine
    {
        public string Food_line_title { get; set; }
        public HashSet<Food> Foods { get; set; }
    }
}
