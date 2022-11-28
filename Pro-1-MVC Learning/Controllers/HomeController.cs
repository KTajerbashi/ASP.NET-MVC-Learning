﻿using Pro_1_MVC_Learning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pro_1_MVC_Learning.Controllers
{
    public class HomeController:Controller
    {
        // Home/Index
        public ActionResult Index()
        {
            // Index
            ViewBag.Title = "INDEX";
            var person = new Person();
            person.Id = 1;
            person.Name = "Kaihan";
            person.LastName = "Tajerbashi";
            person.Age = 30;
            person.Phone = "09020320844";

            return View(person);
        }
    }
}