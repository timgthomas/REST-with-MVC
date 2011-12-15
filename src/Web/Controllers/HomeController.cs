using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		[HttpGet, ActionName("SendRequest")]
		public JsonResult SendRequest_Get(string name)
		{
			return Json(new { message = GetMessage(name, "GET") }, JsonRequestBehavior.AllowGet);
		}

		[HttpPost, ActionName("SendRequest")]
		public JsonResult SendRequest_Post(string name)
		{
			return Json(new { message = GetMessage(name, "POST") });
		}

		[HttpPut, ActionName("SendRequest")]
		public JsonResult SendRequest_Put(string name)
		{
			return Json(new { message = GetMessage(name, "PUT") });
		}

		[HttpDelete, ActionName("SendRequest")]
		public JsonResult SendRequest_Delete(string name)
		{
			return Json(new { message = GetMessage(name, "DELETE") });
		}

		private string GetMessage(string name, string verb)
		{
			return string.Format("{0}, you just sent a {1} request.", name, verb);
		}
	}
}