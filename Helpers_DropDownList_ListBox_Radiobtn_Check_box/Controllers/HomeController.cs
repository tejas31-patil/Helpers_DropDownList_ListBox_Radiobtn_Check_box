using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Helpers_DropDownList_ListBox_Radiobtn_Check_box.Models;

namespace Helpers_DropDownList_ListBox_Radiobtn_Check_box.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            List<string> std1 = new List<string>()
            {
                "Dot net","java","python","Mern"
            };
            ViewBag.std1 = std1;
            List<Students> std = new List<Students>()
            {
                new Students() {Id=1,Name="tejas",CId=1,CName="Dot Net"},
                new Students() {Id=1,Name="Yogesh",CId=1,CName="JAVA"},
                new Students() {Id=1,Name="Vaibhav",CId=1,CName="Python"},
                new Students() {Id=1,Name="Pravin",CId=1,CName="PHP"},
                new Students() {Id=1,Name="Vivek",CId=1,CName="MERN"}
            };
            ViewBag.std = std;
            return View();
        }
        [HttpPost]
        public ActionResult Index(Students std1)
        {

            return RedirectToAction("Index");
        }


    }
}