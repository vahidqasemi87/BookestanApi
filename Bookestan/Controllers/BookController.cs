using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookestan.Models;

namespace Bookestan.Controllers
{
    public class BookController : Controller
    {
        BookestanEntities db = new BookestanEntities();
        // GET: Book
        [HttpGet]
        public JsonResult Index(int? id)
        {
            if (id != null)
            {
                var result = db.USP_Pager(id, 5);
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
                return Json(null, JsonRequestBehavior.AllowGet);
        }
    }
}