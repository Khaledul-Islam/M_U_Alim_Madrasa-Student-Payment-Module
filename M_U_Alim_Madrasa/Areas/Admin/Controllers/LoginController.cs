using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M_U_Alim_Madrasa.Data;
using M_U_Alim_Madrasa.Models;
using Microsoft.AspNetCore.Mvc;

namespace M_U_Alim_Madrasa.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _db;

        public LoginController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

 

        [HttpPost]
        public IActionResult Index(Login log)
        {
            var test = (from s in _db.login
                        where s.Username == log.Username && s.Password == log.Password && s.UserType == log.UserType
                        select s).FirstOrDefault();
            if (test != null)
            {
                if (test.UserType == "Admin")
                {
                    return RedirectToAction("Index", "Admin");
                }
                
            }
            else
            {
                ViewBag.msg = "Username or Password or User Type is incorrect";
            }
            return View();
        }


    }
}