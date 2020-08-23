using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebsiteJimaine.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [RequireHttps]
    public class HomeController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult About()
        {
            ViewBag.Message = "Was genau ist Jimaine?";

            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact()
        {
            ViewBag.Message = "Wie kann man mich erreichen?";

            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult DevelopingDays()
        {
            ViewBag.Message = "Aufzeichnung der Developing Days";

            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult Privacy()
        {
            ViewBag.Message = "Wie wird mit meinen Daten umgegangen?";

            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult ToDo()
        {
            ViewBag.Message = "Was ist hier noch zu tun?";

            return View();
        }
    }
}