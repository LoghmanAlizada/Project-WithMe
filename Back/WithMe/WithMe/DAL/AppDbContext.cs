using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WithMe.Models;

namespace WithMe.DAL
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PageIntro> Pageintros { get; set; }
        public DbSet<OurStory> Ourstroies { get; set; }
        public DbSet<ForSentence> ForSentences { get; set; }
        public DbSet<ForSpecial> ForSpecials { get; set; }
        public DbSet<ForBetweenSection> ForBetweenSections { get; set; }
        public DbSet<HomePageMenu> HomePageMenus { get; set; }
        public DbSet<ForSecondBetweenSection> ForSecondBetweenSections { get; set; }
        public DbSet<ForPartner> ForPartners { get; set; }
        public DbSet<ForThirdBetweenSection> ForThirdBetweenSections { get; set; }
        public DbSet<TitleSectionForMenuPage> TitleSectionForMenuPages { get; set; }
        public DbSet<MainCoursesSectionForMenuPage> MainCoursesSectionForMenuPages { get; set; }
        public DbSet<DrinksSectionForMenuPage> DrinksSectionForMenuPages { get; set; }
        public DbSet<DessertsSectionForMenuPage> DessertsSectionForMenuPages { get; set; }
        public DbSet<TitleSectionForSecondMenuPage> TitleSectionForSecondMenuPages { get; set; }
        public DbSet<MainCoursesSectionForSecondMenu> MainCoursesSectionForSecondMenus { get; set; }
        public DbSet<DessertsSectionForSecondMenu> DessertsSectionForSecondMenus { get; set; }
        public DbSet<DrinksSectionForSecondMenu> DrinksSectionForSecondMenus { get; set; }
        public DbSet<CoffeesSectionForSecondMenu> CoffeesSectionForSecondMenu { get; set; }
        public DbSet<TitleSectionForThirdMenu> TitleSectionForThirdMenus { get; set; }
        public DbSet<DessertsSectionForThirdMenu> DessertsSectionForThirdMenus { get; set; }
        public DbSet<DrinksSectionForThirdMenu> DrinksSectionForThirdMenus { get; set; }
        public DbSet<ChefPage> ChefPages { get; set; }
        public DbSet<ContactPage> ContactPages { get; set; }
        public DbSet<SocialMediaAccounts> SocialMediaAccounts { get; set; }
        public DbSet<GalleryPage> GalleryPages { get; set; }

    }
}
