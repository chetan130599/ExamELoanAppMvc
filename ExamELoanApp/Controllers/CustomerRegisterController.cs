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
    public class CustomerRegisterController : Controller
    {
        LoansDbcontext db = new LoansDbcontext();

        // GET: CustomerRegister
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(customer customer)
        {
            if (ModelState.IsValid)
            {
                db.customers.Add(customer);
                db.SaveChanges();
                return RedirectToAction("Login", "CustomerRegister");

            }
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(CustomerLogin customer)
        {
            if (ModelState.IsValid)
            {
                bool IsValidUser = db.customers
               .Any(u => u.Username.ToLower() == customer
               .Username.ToLower() && customer
               .password == customer.password);

                if (IsValidUser)
                {
                    Session["Username"] = customer.Username.ToString();


                    FormsAuthentication.SetAuthCookie(customer.Username, false); ;
                    return RedirectToAction("AddApplyLoan", "CustomerRegister");
                }
            }
            ModelState.AddModelError("", "invalid Username or Password");
            return View();
        }
        public ActionResult AddApplyLoan()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddApplyLoan(ApplyLoan apply)
        { 
            if (ModelState.IsValid)
            {
                db.ApplyLoans.Add(apply);
                db.SaveChanges();
                return RedirectToAction("AllAppliedLoanList", "CustomerRegister");

            }
            return View();
        }
        public ActionResult AllAppliedLoanList()//display Action.
        {
            var row = db.ApplyLoans.ToList();
            return View(row);
        }
        public ActionResult Delete(int id)//display Action.
        {
            var row = db.ApplyLoans.Where(model => model.ApplyLoanId == id).FirstOrDefault();
            return View(row);
        }

        [HttpPost]
        public ActionResult Delete(ApplyLoan apply)//display Action.
        {
            db.Entry(apply).State = EntityState.Deleted;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)//display Action.
        {
            var row = db.ApplyLoans.Where(model => model.ApplyLoanId == id).FirstOrDefault();
            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(ApplyLoan apply)//display Action.
        {
            db.Entry(apply).State = EntityState.Modified;
            db.SaveChanges();
            return View();
        }

    }
}