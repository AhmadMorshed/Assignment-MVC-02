using Microsoft.AspNetCore.Mvc;

namespace DemoMVC_02.Contorller
{
    public class HomeController : Controller
    {
        //public string Index()
        //{
        //    return "index";
        //}
        //public string AboutUs()
        //{
        //    return "AboutUs";
        //}
        public ActionResult Index()
        {
            //ContentResult result = new ContentResult();
            //result.Content = "Ahmad Morshed";
            //return result;
            return View();
        }
        public ActionResult AboutUs()
        {
            //RedirectToRouteResult result = new RedirectToRouteResult("www.google.com");
            //return result;

            return View();
        }
        public ActionResult Privacy()
        {
            //RedirectToRouteResult result = new RedirectToRouteResult("www.google.com");
            //return result;

            return View();
        }
        public ActionResult ContactUs()
        {
            //RedirectToRouteResult result = new RedirectToRouteResult("www.google.com");
            //return result;

            return View();
        }
    }
}
