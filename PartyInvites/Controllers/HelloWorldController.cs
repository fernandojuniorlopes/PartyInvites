﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PartyInvites.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            String message;

            DateTime now = DateTime.Now;
            
            if(now.Hour > 6 && now.Hour < 12)
            {
                message = "Good Morning";
            }else if(now.Hour >= 12 && now.Hour < 20)
            {
                message = "Good Afternoon";
            }
            else
            {
                message = "Good Night";
            }

            ViewBag.Message = message;
            return View();
        }

        public string Welcome()
        {
            return "Welcome action method !!!";
        }
    }
}