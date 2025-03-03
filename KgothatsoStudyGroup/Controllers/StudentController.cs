using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KgothatsoStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentView()
        {
            List<Models.StudentInfo> students = new List<Models.StudentInfo>();

            students.Add(new Models.StudentInfo { StudentID = 23688794, StudentName = "Kgothatso", StudentSurname = "Naka", StudentEmail = "u23688794@tuks.co.za" });
            students.Add(new Models.StudentInfo { StudentID = 23708795, StudentName = "Jose Edu", StudentSurname = "Solsona", StudentEmail = "u23708795@tuks.co.za" });
            students.Add(new Models.StudentInfo { StudentID = 21543667, StudentName = "Thokozille", StudentSurname = "Sibanyoni", StudentEmail = "u21543667@tuks.co.za" });
            students.Add(new Models.StudentInfo { StudentID = 22609301, StudentName = "Usiphile", StudentSurname = "Gumbi", StudentEmail = "u22609301@tuks.co.za" });



            return View(students);
        }
    }
}