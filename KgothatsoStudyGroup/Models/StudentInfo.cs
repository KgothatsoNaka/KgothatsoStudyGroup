using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace KgothatsoStudyGroup.Models
{
	public class StudentInfo
	{
        [Display(Name = "Student ID")]
        public int StudentID { get; set; }


        [Display(Name = "Name")]
        public string StudentName { get; set; }


        [Display(Name = "Surname")]
        public string StudentSurname { get; set; }


        [Display(Name = "Email Address")]
        public string StudentEmail { get; set; }
    }

}