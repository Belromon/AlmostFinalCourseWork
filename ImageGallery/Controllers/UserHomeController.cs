using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageGallery.Controllers
{
    public class UserHomeController : Controller
    {
        [Authorize]
        public ActionResult AccountIndex()
        {
            Dictionary<string, object> data
                = new Dictionary<string, object>();
            data.Add("Ключ", "Значение");
            return View(data);
        }
    }
}