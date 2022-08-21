using System.Collections.Generic;
using WithMe.Models;

namespace WithMe.ViewModels
{
    public class SecondMenuVM
    {
        public TitleSectionForSecondMenuPage titlesectionforsecondmenupage { get; set; }
        public List<MainCoursesSectionForSecondMenu> maincoursessectionforsecondmenu { get; set; }
        public List<DessertsSectionForSecondMenu> dessertssectionforsecondmenu { get; set; }
        public List<DrinksSectionForSecondMenu> drinkssectionforsecondmenu { get; set; }
        public List<CoffeesSectionForSecondMenu> coffeessectionforsecondmenu { get; set; }



    }
}
