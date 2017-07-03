using MkCodeFirst.UnitofWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MkCodeFirst.Controllers
{
    public class BaseController : Controller
    {
        protected UnitofWorks uow = null;
        //
        // GET: /Emloyees/

        public BaseController()
        {
            uow = new UnitofWorks();
        }

        public BaseController(UnitofWorks uow_)
        {
            this.uow = uow_;
        }


        protected override void Dispose(bool disposing)
        {
            uow.Dispose();
            base.Dispose(disposing);
        }









    }
}