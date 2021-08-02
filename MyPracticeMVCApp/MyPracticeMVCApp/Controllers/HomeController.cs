using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPracticeMVCApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Product()
        {
            return View("CompanyProduct");
        } 
        public ActionResult Contact()
        {
            ViewBag.TollFeeNo = "123-123-123";
            return View();
        }

        public ActionResult GetEmployeeName(int employeeId)
        {
            var employees = new[] {
                new { EmpId = 1, EmpName = "Scott", Salary = 8000},
                new { EmpId = 2, EmpName = "Tim", Salary = 9000},
                new { EmpId = 3, EmpName = "Kevin", Salary = 10000},
            };

            string matchEmployee = null;
            foreach (var emp in employees)
            {
                if (emp.EmpId == employeeId)
                {
                    matchEmployee = emp.EmpName;
                }
            }

            //return new ContentResult() { Content = matchEmployee, ContentType="text/plain"} ;
            return Content(matchEmployee, "text/plain");
        }

        public ActionResult GetEmployeePaySlip(int empId)
        {
            string fileName = "~/payslip" + empId + ".pdf";
            return File(fileName,"application/pdf");
        }

        public ActionResult EmployeeFacebookPage(int empId)
        {
            var employees = new[] {
                new { EmpId = 1, EmpName = "Scott", Salary = 8000},
                new { EmpId = 2, EmpName = "Tim", Salary = 9000},
                new { EmpId = 3, EmpName = "Kevin", Salary = 10000},
            };

            string fbURL = null;
            foreach (var emp in employees)
            {
                if (emp.EmpId == empId)
                {
                    fbURL = "http://www.facebook.com/emp" + empId;
                }
            }

             
            
             if (fbURL != null)
                return Redirect(fbURL);
            else
                return Content("Input Is Invalid");
        }

        public ActionResult GetStudentDetails(int empId)
        {
            ViewBag.StudentId = 101;
            ViewBag.Name = "Don";
            ViewBag.Course = "Maths";
            ViewBag.Marks = 80;
            ViewBag.TotalSem = 6;
            ViewBag.Subjects = new string[] { "Computer", "C", "Java" };

            return View();
        }

    }
}