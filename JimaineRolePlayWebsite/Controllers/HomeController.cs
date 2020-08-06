﻿using System;
using System.Web.Mvc;

namespace JimaineRolePlayWebsite.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DevelopingDays()
        {
            ViewBag.Message = "Aufzeichnung der Developing Days";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Was genau ist Jimaine?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Wie kann man mich erreichen?";

            return View();
        }

        public ActionResult Privacy()
        {
            ViewBag.Message = "Wie wird mit meinen Daten umgegangen?";

            return View();
        }

        public ActionResult ToDo()
        {
            ViewBag.Message = "Was ist hier noch zu tun?";

            return View();
        }
    }
}