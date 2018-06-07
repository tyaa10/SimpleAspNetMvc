using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        /*public String Index()
        {
            return "Hello!";
        }*/
        /*public String Index(int id = 0)
        {
            return $"id = {id}";
        }*/

        //private string login = "";
        //private string password = "";
        //private AspMvcDbEntities db;

        public DefaultController() {

            //db = new AspMvcDbEntities();
        }

        [HttpGet]
        public ViewResult Index()
        {
            /*ViewBag.login = Session["login"] as string;
            ViewBag.password = Session["password"] as string;*/

            var show = Session["show"];
            if (show != null)
            {
                ViewBag.show = "show";
                Session["show"] = null;
            }
            else {

                ViewBag.show = "";
            }

            ViewBag.name = Session["name"] as string;
            ViewBag.email = Session["email"] as string;
            ViewBag.message = Session["message"] as string;
            return View();
        }

        //[HttpGet]
        /*public String Index2()
        {
            
            //return db.Groups.Select(g => g.);
        }*/

        [HttpPost]
        public RedirectToRouteResult ProcessPost(FeedBackData _feedBackData) {

            /*Session["login"] = _authData.login;
            Session["password"] = _authData.password;*/
            Session["name"] = _feedBackData.name;
            Session["email"] = _feedBackData.email;
            Session["message"] = _feedBackData.message;
            Session["show"] = "show";
            return RedirectToAction("Index");
        }
    }
}