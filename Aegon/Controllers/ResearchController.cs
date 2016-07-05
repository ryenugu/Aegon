using System.Web.Mvc;

namespace Aegon.Controllers
{
    public class ResearchController : Controller
    {
        // GET: Research
        public ActionResult Index()
        {
            return View();
        }

        public void Test()
        {
            dynamic d = 7;
            int i = d;
        }
    }
}