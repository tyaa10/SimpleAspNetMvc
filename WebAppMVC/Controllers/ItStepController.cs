using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppMVC.Controllers
{
    public class ItStepController : Controller
    {
        private AspMvcDbEntities db;

        public ItStepController() {

            db = new AspMvcDbEntities();
        }
        // GET: ItStep
        public ViewResult Index()
        {
            var groups = db.Groups.ToList().AsQueryable<Group>();
            return View(groups);
        }
    }
}