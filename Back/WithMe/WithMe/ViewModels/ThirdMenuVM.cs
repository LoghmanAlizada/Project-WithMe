using System.Collections.Generic;
using WithMe.Models;

namespace WithMe.ViewModels
{
    public class ThirdMenuVM
    {
        public TitleSectionForThirdMenu titlesectionforthirdmenu { get; set; }
        public List<DessertsSectionForThirdMenu> dessertssectionforthirdmenu { get; set; }
        public List<DrinksSectionForThirdMenu> drinkssectionforthirdmenu { get; set; }

    }
}
