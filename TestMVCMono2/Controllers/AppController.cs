using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestMVCMono2
{
	public class AppController : Controller
	{
		// GET: App
		public ActionResult Index()
		{
			return View();
		}

		// GET: App
		public ActionResult App1()
		{
			return View();
		}

		// GET: App
		public ActionResult App2()
		{
			return View();
		}
	}
}

