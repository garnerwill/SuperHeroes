using SuperheroProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperheroProject.Controllers
{
    public class SuperHerosController : Controller
    {
        private ApplicationDbContext db;
        public SuperHerosController()
        {
            db = new ApplicationDbContext();
        }
        // GET: SuperHeros
        public ActionResult Index()
        {
            return View();
        }

        // GET: SuperHeros/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        

        // GET: SuperHeros/Create
        public ActionResult Create()
        {
            Superhero superheros = new Superhero();
            return View(superheros);
        }

        // POST: SuperHeros/Create
        [HttpPost]
        public ActionResult Create(Superhero superhero)
            
        {
            try
            {
                // TODO: Add insert logic here
                db.superheroes.Add(superhero);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeros/Edit/5
        public ActionResult Edit(int id, Superhero superhero)
        {
            db.superheroes.Remove (superhero);
            return RedirectToAction("Index");
            return View();
        }

        // POST: SuperHeros/Edit/5
        [HttpPost]
        public ActionResult Update(int id, Superhero)
        {
            try
            {
                db.superheroes.ToList<SuperHerosController>(superhero);
                return RedirectToAction("Index");
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeros/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperHeros/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
