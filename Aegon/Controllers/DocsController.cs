using System.Web;
using System.Web.Mvc;
namespace Aegon.Controllers
{
    public class DocsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}