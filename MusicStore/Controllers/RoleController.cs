using MusicStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class RoleController : Controller
    {
        ApplicationDbContext context;


        public RoleController()
        {
            context = new ApplicationDbContext();
        }


        // GET: Role
        public ActionResult Index()
        {
            var Roles = context.Roles.ToList();
            return View(Roles);
        }


    }
}