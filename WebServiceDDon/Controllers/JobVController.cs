using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebServiceDDon.Infra.Repository;
using WebServiceDDon.Models;

namespace WebServiceDDon.Controllers
{
    public class JobVController : Controller
    {
        JobRepository Db = new JobRepository();
        // GET: JobV
        public ActionResult Index()
        {
            return View(Db.List());
        }

        // GET: JobV/Details/5
        public ActionResult Details(int id)
        {
            Job job = Db.FindById(id);
            TempData["HabPt"] = new HabilidadesRepository().List(1, job.Id_Job).ToList();
            TempData["HabUs"] = new HabilidadesRepository().List(2, job.Id_Job).ToList();

            TempData["PasPt"] = new PassivasRepository().List(1, job.Id_Job).ToList();
            TempData["PasUs"] = new PassivasRepository().List(2, job.Id_Job).ToList();
            
            return View(job);
        }

        // GET: JobV/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JobV/Create
        [HttpPost]
        public ActionResult Create(Job job)
        {
            if(ModelState.IsValid)
            {
                Db.Add(job);
                return RedirectToAction("Index");
            }
            return View(job);
            
        }

        // GET: JobV/Edit/5
        public ActionResult Edit(int id)
        {
            return View(Db.FindById(id));
        }

        // POST: JobV/Edit/5
        [HttpPost]
        public ActionResult Edit(Job job)
        {
            if(ModelState.IsValid)
            {
                Db.Edit(job);
                return RedirectToAction("Index");
            }
            return View(job);
        }
    }
}
