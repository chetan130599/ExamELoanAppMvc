using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using ExamELoanApp.Models;

namespace ExamELoanApp.Controllers
{
    public class ManagerController : Controller
    {
        LoansDbcontext db = new LoansDbcontext();
        
        // GET: Manager
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registeration()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registeration(Manager manager)
        {
            if (ModelState.IsValid)
            {
                db.managers.Add(manager);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");

            }
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(ManagerLogin manager)
        {
            if (ModelState.IsValid)
            {
                bool IsValidUser = db.managers
               .Any(u => u.Username.ToLower() == manager
               .Username.ToLower() && manager
               .password == manager.password);

                if (IsValidUser)
                {
                    Session["Username"] = manager.Username.ToString();


                    FormsAuthentication.SetAuthCookie(manager.Username, false); ;
                    return RedirectToAction("AppliedLoanlist", "Manager");
                }
            }
            ModelState.AddModelError("", "invalid Username or Password");
            return View();
        }
        public ActionResult AppliedLoanlist()//display Action.
        {
            var row = db.ApplyLoans.ToList();
            return View(row);
        }
        public ActionResult Accept(int id)//display Action.
        {
            var row = db.ApplyLoans.Where(model => model.ApplyLoanId == id).FirstOrDefault();
            return View(row);
        }
        [HttpPost]
        public ActionResult Accept(ApplyLoan apply)//display Action.
        {
            db.Entry(apply).State = EntityState.Modified;
            db.SaveChanges();
            return View();
        }
    }
}