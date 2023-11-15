using Microsoft.AspNetCore.Mvc;
using MVCPARTTwo.Models;

namespace MVCPARTTwo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>();
            Student student1 = new Student() { Fullname = "Enver Zohrabov",Id=1,Age= 23, Grant = 200, GroupId = 1};
            Student student2 = new Student() { Fullname = "Eli Qeribov",Id=2,Age= 123, Grant = 2200, GroupId = 1};
            Student student3 = new Student() { Fullname = "Veli Nesibov",Id=3,Age= 25, Grant = 6200, GroupId = 12};
            Student student4 = new Student() { Fullname = "Sirveli Eyyubov",Id=4,Age= 13, Grant = 8200, GroupId = 11};
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);
            students.Add(student4);

            return View(students);
        }

        public IActionResult Detail(int id)
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

            Student wantedStudent = students.FirstOrDefault(x=>x.Id == id);

            if(wantedStudent == null) 
            {
                return NotFound();
            }

            return View(wantedStudent);
        }
    }
}
