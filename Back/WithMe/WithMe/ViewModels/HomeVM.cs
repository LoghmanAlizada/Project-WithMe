using System.Collections.Generic;
using WithMe.Models;

namespace WithMe.ViewModels
{
    public class HomeVM
    {
        public PageIntro pageintro { get; set; }
        public OurStory ourstory { get; set; }
        public ForSentence forsentence { get; set; }
        public List<ForSpecial> forspeacial { get; set; }
        public List<ForBetweenSection> forbetweensection { get; set; }
        public List<HomePageMenu> homepagemenu { get; set; }
        public ForSecondBetweenSection forsecondbetweensection { get; set; }
        public ForPartner forpartner { get; set; }
        public ForThirdBetweenSection forthirdbetweensection { get; set; }


    }
}
