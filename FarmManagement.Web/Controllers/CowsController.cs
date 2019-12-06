using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using FarmManagement.Data;
using FarmManagement.Data.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace FarmManagement.Web.Controllers
{
    public class CowsController : Controller
    {
        public MainContext _mainContext;
        public RepositoryBase<Cattle> db;
        public CowsController(MainContext mainContext)
        {
            _mainContext = mainContext;
            db = new RepositoryBase<Cattle>(_mainContext);

        }
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }


    }
}