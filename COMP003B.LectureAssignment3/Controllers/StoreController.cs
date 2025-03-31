using Microsoft.AspNetCore.Mvc;

namespace COMP003B.LectureAssignment3.Controllers
{
    [Route("store")]
    public class StoreController : Controller
    {
        //Get: store/product/5
        [Route("product/{id:int}")]
        public IActionResult ViewProduct(int id)
        {
            //
            return View(id);
        }
        [HttpGet("product/search")]
        public IActionResult Search([FromQuery] string category)
        {
            return View("Search", category);
        }
    }
}
