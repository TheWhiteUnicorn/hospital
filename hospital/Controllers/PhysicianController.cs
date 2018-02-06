using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess.Models;
using DataAccess;
using System.Data.Entity;

namespace hospital.Controllers
{
	public class PhysicianController : Controller
	{
		SampleContext db = new SampleContext();

		// GET: Physician
		public ActionResult Index()
		{
			var physician = db.Physicians;
			return View(physician);
		}

		// GET: Physician/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Physician/Create
		[HttpPost]
		public ActionResult Create(Physician physician)
		{
			db.Physicians.Add(physician);
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		// GET: Physician/Edit
		public ActionResult Edit(int id)
		{
			var physician = db.Physicians.Find(id);
			return View(physician);
		}

		// POST: Physician/Edit
		[HttpPost]
		public ActionResult Edit(Physician physician)
		{
			physician.Id = 1;
			db.Entry(physician).State = EntityState.Modified;
			db.SaveChanges();
			return RedirectToAction("Index");
		}
    }
}