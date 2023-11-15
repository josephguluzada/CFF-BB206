using AdoNET.Abstratcs;
using AdoNET.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNET.Concretes
{
    public class StudentService : IService<Student>
    {
        public void Create(Student student)
        {
            int result = SQLManager.Execute($"INSERT INTO Students VALUES ('{student.Fullname}',{student.Grant},{student.GroupId})");

            if (result > 0) Console.WriteLine("Inserted!");
            else Console.WriteLine("Error!");
        }

        public void Delete(int id)
        {
            int result = SQLManager.Execute($"DELETE FROM Students WHERE Id = {id}");


            if (result > 0) Console.WriteLine("Deleted!");
            else Console.WriteLine("Error!");
        }

        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>();
            var datas = SQLManager.Reader("SELECT * FROM Students");

            foreach (DataRow data in datas.Rows)
            {
                students.Add(new Student { Id = Convert.ToInt32(data[0]), Fullname = data[1].ToString(), Grant = Convert.ToDecimal(data[2]), GroupId = Convert.ToInt32(data[3]) });
            }
            return students;
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
