﻿using MyClass.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _63CNTT4N1.Controllers
{
    public class TimkiemController : Controller
    {
        // GET: Timkiem
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string searchString)
        {
            ViewBag.searchString = searchString;
            ProductsDAO productsDAO = new ProductsDAO();
            var products = productsDAO.getList("Index");
            var product = products.Where(p => p.Name.ToLower().Contains(searchString));
            if (product != null)
            {
                return View(product);
            }
            return View();
        }
    }
}