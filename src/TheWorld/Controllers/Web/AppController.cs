using System;

namespace TheWorld.Controllers.Web
{
    public class AppController
    {
        public IActionResult index()
        {
            return View();
        }
    }
}