using Microsoft.AspNetCore.Mvc;

namespace COMP003B.LectureAssignment3.Controllers
{
    public class ShopController : Controller
    {
        //GET: /shop/
        [HttpGet]
        public IActionResult Index()
        {
            //view methods return a view of results that rendersa  view of the respones
            return View();
        }

        //GET: /shop/details/5
        [HttpGet]
        public IActionResult Details(int id)
        {
            //the view method returns a view that renders a view to the response
            //the id parament is passed to the view
            return View(id);
        }
    }
}
