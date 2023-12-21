using AuthorBook.Data;
using AuthorBook.DTOs.AuthorDtos;
using AuthorBook.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuthorBook.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AuthorsController : ControllerBase
	{
		private readonly AppDbContext _context;

		public AuthorsController(AppDbContext context)
        {
			_context = context;
		}

        [HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			var author = await _context.Authors.Where(x=> !x.IsDeleted).FirstOrDefaultAsync(x=>x.Id == id);
			if (author == null) return NotFound(); // 404

			AuthorGetDto authorGetDto = new AuthorGetDto()
			{
				Id = author.Id,
				Name = author.Name,
			};

			return Ok(authorGetDto);
		}

		[HttpPost]
		public async Task<IActionResult> Create(AuthorCreateDto dto)
		{
			Author author = new Author()
			{
				Name = dto.Name
			};

			author.CreatedDate = DateTime.UtcNow.AddHours(4);
			author.UpdatedDate = DateTime.UtcNow.AddHours(4);
			author.IsDeleted = false;
			

			await _context.Authors.AddAsync(author);
			await _context.SaveChangesAsync();

			return StatusCode(201);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> Update(int id, AuthorUpdateDto dto)
		{
			var author = await _context.Authors.FirstOrDefaultAsync(x => x.Id == id);

			if (author == null) return NotFound(); //404

			author.Name = dto.Name;
			author.UpdatedDate = DateTime.UtcNow.AddHours(4);

			await _context.SaveChangesAsync();

			return NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> SoftDelete(int id)
		{
			var author = await _context.Authors.FirstOrDefaultAsync(x=>x.Id ==id);

			if (author == null) return NotFound(); //404

			author.IsDeleted = !author.IsDeleted;
			author.UpdatedDate= DateTime.UtcNow.AddHours(4);
			await _context.SaveChangesAsync();

			return StatusCode(204);
		}

		//[HttpDelete("revertsoftdelete/{id}")]
		//public async Task<IActionResult> RevertSoftDelete(int id)
		//{
		//	var author = await _context.Authors.FirstOrDefaultAsync(x => x.Id == id);

		//	if (author == null) return NotFound(); //404

		//	author.IsDeleted = false;
		//	author.UpdatedDate = DateTime.UtcNow.AddHours(4);
		//	await _context.SaveChangesAsync();

		//	return StatusCode(204);
		//}

	}
}
