using FluentValidation;

namespace AuthorBook.DTOs.AuthorDtos
{
	public class AuthorCreateDto
	{
        public string Name { get; set; }
    }

	public class AuthorCreateDtoValidator : AbstractValidator<AuthorCreateDto>
	{
        public AuthorCreateDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Bos ola bilmez!")
                .NotNull().WithMessage("Null ola bilmez!")
                .MaximumLength(50).WithMessage("Max 50 ola biler!")
				.MinimumLength(5).WithMessage("Min 5 ola biler!");
		}
    }
}
