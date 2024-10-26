using Microsoft.AspNetCore.Mvc;
using VideoStore.Models;

namespace VideoStore.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);
        }
    }
}
