using AdoNET.Concretes;
using AdoNET.Models;

namespace AdoNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student();

            std1.Fullname = "Enver Zohrabov";
            std1.GroupId = 2;
            std1.Grant = 9000;

            //StudentService studentService = new StudentService();


            //studentService.Create(std1);

            //studentService.Delete(15);

            //foreach (var item in studentService.GetAll())
            //{
            //    Console.WriteLine(item);
            //}

            //CreateStudent(std1);

            //Delete(1);

        }

        static void CreateStudent(Student student)
        {
            AppDbContext appContext = new AppDbContext();

            appContext.Students.Add(student);
            appContext.SaveChanges();
        }

        static void Delete(int id)
        {
            AppDbContext dbContext = new AppDbContext();

            Student wantedStudent = dbContext.Students.Find(id);
            if(wantedStudent != null)
            {
                dbContext.Students.Remove(wantedStudent);
            }
            dbContext.SaveChanges();
        }

    }
}