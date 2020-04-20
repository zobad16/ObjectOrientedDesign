﻿using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            User user = new User() { Id = 1, FirstName = "Zobad", LastName = "Mahmood", Email="abc@cde.com" , UserName="zobadmahmood" };
            return View("UserProfile",user);
        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Edit/5
       /* [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(id);
        }
        */
        // POST: Users/Edit/5
        [HttpPost]
        public ActionResult Edit( int id, string username,string firstname, string lastname)
        {
            try
            {
                User user = new User() {Id=id,UserName=username, FirstName=firstname, LastName=lastname };
                // TODO: Add update logic here

                return View(user);
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Users/Delete/5
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
