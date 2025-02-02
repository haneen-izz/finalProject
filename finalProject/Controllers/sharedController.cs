﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace finalProject.Controllers
{
    public class sharedController : Controller
    {
        // GET: sharedController
        public ActionResult Index()
        {
            return View();
        }

        // GET: sharedController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: sharedController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: sharedController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: sharedController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: sharedController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: sharedController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: sharedController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
