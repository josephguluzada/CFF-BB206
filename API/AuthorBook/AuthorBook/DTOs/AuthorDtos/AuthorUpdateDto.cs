using FluentValidation;

namespace AuthorBook.DTOs.AuthorDtos
{
	public class AuthorUpdateDto
	{
        public string Name { get; set; }
    }

	public class AuthorUpdateDtoValidator : AbstractValidator<AuthorUpdateDto>
	{
        public AuthorUpdateDtoValidator()
        {
            RuleFor(x=>x.Name)
				.NotEmpty().WithMessage("Bos ola bilmez!")
				.NotNull().WithMessage("Null ola bilmez!")
				.MaximumLength(50).WithMessage("Max 50 ola biler!")
				.MinimumLength(5).WithMessage("Min 5 ola biler!");
		}
    }
}
