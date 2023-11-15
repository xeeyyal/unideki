using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Topic topic1 = new() { Id=1, IconName= "restaurant",Name="Restaurant",Count=100 };
            Topic topic2 = new() { Id = 2, IconName = "travel", Name = "Destination", Count = 200 };
            Topic topic3 = new() { Id = 3, IconName = "building", Name = "Hotels", Count = 300 };
            Topic topic4 = new() { Id = 4, IconName = "pills", Name = "Healthcaree", Count = 400 };
            Topic topic5 = new() { Id = 5, IconName = "transport", Name = "Automation", Count = 500 };

            Service service1 = new() { Id = 1, IconName = "lightbulb-idea", Name = "Choose", Description = "Desc1" };
            Service service2 = new() { Id = 2, IconName = "networking", Name = "Find", Description = "Desc2" };
            Service service3 = new() { Id = 3, IconName = "location-on-road", Name = "Explore", Description = "Desc3" };

            Explore explore1 = new() { Id = 1, Name = "Tommy", ImgSrcName = "/assets/images/explore/e1.jpg", Rating = 8.0, Description = "Desc1",IsOpen=false,Count=15 };
            Explore explore2 = new() { Id = 2, Name = "Tommy", ImgSrcName = "/assets/images/explore/e1.jpg", Rating = 9.5, Description = "Desc2", IsOpen = true, Count = 15 };
            Explore explore3 = new() { Id = 3, Name = "Tommy", ImgSrcName = "/assets/images/explore/e1.jpg", Rating = 10.4, Description = "Desc3", IsOpen = false, Count = 15 };
            Explore explore4 = new() { Id = 4, Name = "Tommy", ImgSrcName = "/assets/images/explore/e1.jpg", Rating = 11.5, Description = "Desc4", IsOpen = true, Count = 15 };
            Explore explore5 = new() { Id = 5, Name = "Tommy", ImgSrcName = "/assets/images/explore/e1.jpg", Rating = 12.2, Description = "Desc5", IsOpen = false, Count = 15 };
            Explore explore6 = new() { Id = 6, Name = "Tommy", ImgSrcName = "/assets/images/explore/e1.jpg", Rating = 13.9, Description = "Desc6", IsOpen = true, Count = 15 };

            List<Topic> topics = new() { topic1,topic2, topic3, topic4, topic5 };
            List<Service> services = new() { service1, service2, service3 };
            List<Explore> explores = new() { explore1, explore2, explore3, explore4, explore5, explore6 };

            HomeVM vm = new()
            {
                Topics = topics,
                Services = services,
                Explores= explores
            };

            return View(vm);
        }
    }
}
