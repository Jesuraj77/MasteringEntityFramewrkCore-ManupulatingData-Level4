using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Level3.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Index()
        {
           // Implement to delete data from the database using Entity Framework core API.
                //a.Create web API delete method.
       //b.Use entry method to set deleted state.
       //c.Use method to handleobject graph deletes.


            return View();
        }
    }
}