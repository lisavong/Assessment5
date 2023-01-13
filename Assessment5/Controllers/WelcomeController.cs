﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assessment5.Controllers
{
    public class WelcomeController : Controller
    {
        // GET: WelcomeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: WelcomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: WelcomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WelcomeController/Create
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

        // GET: WelcomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: WelcomeController/Edit/5
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

        // GET: WelcomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WelcomeController/Delete/5
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
