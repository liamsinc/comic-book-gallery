using System;
using Microsoft.AspNetCore.Mvc;


namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        public string Detail()
        {
            return "Hello from the comic books controller!";
        }
    }
}

