using Microsoft.AspNet.Mvc;
using System;

namespace TheWorld.Controllers.Web
{
    public class AppController: Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}