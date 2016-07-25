﻿/**
 * @author: Siqian Yu, Fei Wang
 * @date: July 24, 2016
 * @description: This is the Menu Controller
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace COMP2007_S2016_Assignment2_Restaurant.Controllers
{
    public class MenuController : Controller
    {
        //
        // GET: /Menu/
        public ActionResult Index()
        {
            return View();
        }
        //
        // GET: /Menu/Browse?type=Appetizer
        public ActionResult Browse(string type)
        {
            Foodtype typeModel = new Foodtype(type);

            return View(typeModel);
        }
        //
        // GET: /Menu/Details/1
        public ActionResult Details(int id = 1)
        {
            Fooditem item = new Fooditem("Fooditem " + id);

            return View(item);
        }
    }
}