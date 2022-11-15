using Microsoft.AspNetCore.Mvc;

namespace HomeworkASP.Controllors
{
    public class HomeController:Controller
    {
        //public ContentResult Index()
        //{
        //    ContentResult cr = new ContentResult();
        //    cr.Content = "<h1>Salam ,Dunya</h1>";
        //    return cr;
        //}


        public ViewResult Index()
        {
            ViewResult vr = new ViewResult();
            vr.ViewName = "Index";
            return vr;
        }

        public ViewResult About()
        {
            ViewResult vr = new ViewResult();
            vr.ViewName = "about";
            return vr;
        }

        public ContentResult Content(int id, string name, string surname)
        {
            ContentResult cr = new ContentResult();
            cr.Content = $"Fullname:{id} - {name} {surname}";
            return cr;
        }
        public ViewResult Contact()
        {
            return View();
        }
        public ViewResult Faq()
        {
            return View();
        }
    }
}
