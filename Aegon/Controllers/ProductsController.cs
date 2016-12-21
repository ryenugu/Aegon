using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace Aegon.Controllers
{
    public class ProductsController : Controller
    {
        private readonly MpiEntities _db = new MpiEntities();

        // GET: Products
        public ActionResult Index()
        {
            return View(_db.MpiHeader_Test.ToList());
        }

        // GET: Products/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var mpiHeaderTest = _db.MpiHeader_Test.Find(id);
            if (mpiHeaderTest == null)
            {
                return HttpNotFound();
            }
            return View(mpiHeaderTest);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Code,Name,HCAUniverse,Index")] MpiHeader_Test mpiHeaderTest)
        {
            if (ModelState.IsValid)
            {
                _db.MpiHeader_Test.Add(mpiHeaderTest);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mpiHeaderTest);
        }

        // GET: Products/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var mpiHeaderTest = _db.MpiHeader_Test.Find(id);
            if (mpiHeaderTest == null)
            {
                return HttpNotFound();
            }
            return View(mpiHeaderTest);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Code,Name,HCAUniverse,Index")] MpiHeader_Test mpiHeaderTest)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(mpiHeaderTest).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mpiHeaderTest);
        }

        // GET: Products/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var mpiHeaderTest = _db.MpiHeader_Test.Find(id);
            if (mpiHeaderTest == null)
            {
                return HttpNotFound();
            }
            return View(mpiHeaderTest);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            var mpiHeaderTest = _db.MpiHeader_Test.Find(id);
            _db.MpiHeader_Test.Remove(mpiHeaderTest);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}