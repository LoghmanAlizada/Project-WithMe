using System.Collections.Generic;
using WithMe.Models;

namespace WithMe.ViewModels
{
    public class MenuVM
    {
        public TitleSectionForMenuPage titlesectionformenupage { get; set; }
        public List<MainCoursesSectionForMenuPage> maincoursessectionformenupage { get; set; }
        public List<DrinksSectionForMenuPage> drinkssectionformenupages { get; set; }
        public List<DessertsSectionForMenuPage> dessertsectionformenupages { get; set; }

    }
}
