using System;
using Microsoft.AspNetCore.Mvc;


namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return Redirect("/");
            }

            return Content("Hello from the comic books controller!");
        }
    }
}