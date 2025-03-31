using Microsoft.AspNetCore.Mvc;

namespace COMP003B.LectureAssignment3.Controllers
{
    //The [Route("product")] attributee specifies that the controller will handle request that start with "/product".
    [Route("product")]
    public class ProductController : Controller
    {
        //Get: product/create
        [HttpGet("create")]
        public IActionResult Create()
        {
            //the view() method returns a view result that renders view to the response. 
            return View();
        }

        //Post: Product/create 
        [HttpPost("create")]
        public IActionResult Create([FromForm] ProductController product)
        {
            //the modelstate.isvalid property chedcks if the models state is valid.
            if (!ModelState.IsValid)
            {
                return View(product);
            }

            //The redirecttoaction method return a redict result that redirects to an action.
            return RedirectToAction("Succes", product);
        }

        //Get:products/sucess
        [Route("Succes")]
        public IActionResult Success(ProductController product)
        {
            //the view method returns a view result that renders a view to the response
            return View(product);
        }
    }
}
