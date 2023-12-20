using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StudentsAPP.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class StudentsController : ControllerBase
	{
		private static List<Student> _students =  new List<Student>()
			{
				new Student()
				{
					Id = 1,
					Name = "Elmar"
				},
				new Student()
				{
					Id = 2,
					Name = "Ramzi"
				},
				new Student()
				{
					Id = 3,
					Name = "Raksana"
				},
				new Student()
				{
					Id = 4,
					Name = "Hemid"
				},
			};

		[HttpGet("getall")]
		//[Route("")]
		public IActionResult GetAll()
		{
			return Ok(_students);
		}

		
		[HttpGet("{id}")]
		//[Route("{id}")]
		public IActionResult Get(int id)
		{
			var student = _students.FirstOrDefault(x => x.Id == id);

			return Ok(student);
		}
		[HttpPost]
		public IActionResult Create(Student student)
		{
			_students.Add(student);

			return Ok(student);
		}

		[HttpPut]
		public IActionResult Update(Student student)
		{
			var std = _students.FirstOrDefault(x=>x.Id == student.Id);

			std.Name = student.Name;

			return Ok(std);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var std = _students.FirstOrDefault(x => x.Id == id);
			_students.Remove(std);

			return Ok();
		}


	}
}
