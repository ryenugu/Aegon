using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;
using Dapper;

namespace Aegon.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View(GetAll());
        }

        public List<MpiHeader_Test> GetAll()
        {
            var efConnectionString = ConfigurationManager.ConnectionStrings["MpiEntities"].ConnectionString;
            var builder = new EntityConnectionStringBuilder(efConnectionString);
            var regularConnectionString = builder.ProviderConnectionString;


            IDbConnection db = new SqlConnection(regularConnectionString);
            return db.Query<MpiHeader_Test>("select * from Mpiheader_Test where name like 'a%' order by name").ToList();
        }
    }
}