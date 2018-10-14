﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers.Home
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            return View("Index");
        }

        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
