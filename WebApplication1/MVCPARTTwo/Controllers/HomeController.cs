﻿using Microsoft.AspNetCore.Mvc;
using MVCPARTTwo.Models;
using MVCPARTTwo.ViewModels;

namespace MVCPARTTwo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            Student student1 = new Student() { Fullname = "Enver Zohrabov", Id = 1, Age = 23, Grant = 200, GroupId = 1 };
            Student student2 = new Student() { Fullname = "Eli Qeribov", Id = 2, Age = 123, Grant = 2200, GroupId = 1 };
            Student student3 = new Student() { Fullname = "Veli Nesibov", Id = 3, Age = 25, Grant = 6200, GroupId = 12 };
            Student student4 = new Student() { Fullname = "Sirveli Eyyubov", Id = 4, Age = 13, Grant = 8200, GroupId = 11 };
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);

            List<Teacher> teachers = new List<Teacher>();
            Teacher tch1 = new Teacher() { Fullname = "Envera Zohrabov", Id = 1, Age = 23, Salary = 20000 };
            Teacher tch2 = new Teacher() { Fullname = "Elia Qeribov", Id = 2, Age = 123, Salary = 220000 };
            Teacher tch3 = new Teacher() { Fullname = "Velia Nesibov", Id = 3, Age = 25, Salary = 620000 };
            Teacher tch4 = new Teacher() { Fullname = "Sirvelia Eyyubov", Id = 4, Age = 13, Salary = 820000 };
            teachers.Add(tch1);
            teachers.Add(tch2);
            teachers.Add(tch3);
            teachers.Add(tch4);

            //ViewBag.Teachers = teachers;
            HomeViewModel homeVM = new HomeViewModel();
            homeVM.Students = students;
            homeVM.Teachers = teachers;

            return View(homeVM);
        }
    }
}
