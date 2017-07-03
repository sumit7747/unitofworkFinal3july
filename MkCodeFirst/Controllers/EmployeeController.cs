using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MkCodeFirst.Models;
using MkCodeFirst.UnitofWork;

namespace MkCodeFirst.Controllers
{
    public class EmployeeController : BaseController
    {
      
        public ActionResult Index()
        {
            return View(uow.Repository<Emloyee>().GetAll().ToList());
        }


        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Emloyees/Create

        [HttpPost]
        public ActionResult Create(Emloyee Emloyee)
        {
            if (ModelState.IsValid)
            {
                uow.Repository<Emloyee>().Insert(Emloyee);
                uow.Save();
                return RedirectToAction("Index");
            }

            return View(Emloyee);
        }

     

      //  [HttpPut]
        public ActionResult DoSomething(int id)
        {
              //uow.Repository<Emloyee>().Insert(Emloyee);
              //  uow.Save();
              //  return RedirectToAction("Index");
            uow.EmployeeRepo.DoSomething(id);
            uow.Save();
            return RedirectToAction("Index");
        }









    }
}
