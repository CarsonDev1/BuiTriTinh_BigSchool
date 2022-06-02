using BuiTriTinh_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuiTriTinh_BigSchool.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult create()
        {
            BigSchool context = new BigSchool();
            Course objCourse = new Course();
            objCourse.ListCategory = context.Categories.ToList();

            return View(objCourse);
        }
    }
}