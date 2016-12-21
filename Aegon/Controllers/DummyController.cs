using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace Aegon.Controllers
{
    public class DummyController : Controller
    {
        // GET: Dummy
        public string Index()
        {
            return "Hello from DummyController.Index()";
        }

        public string Browse(int id)
        {
            return HttpUtility.HtmlEncode("Asset class=" + id);
        }

        public ActionResult List()
        {
            var products = new List<MpiHeader_Test>();
            for (int i = 0; i < 10; i++)
            {
                products.Add(new MpiHeader_Test { Name = "Ravi Cap " + i, Code = "RY", Index = "SP500" });
            }
            return View(products);
        }
    }
}