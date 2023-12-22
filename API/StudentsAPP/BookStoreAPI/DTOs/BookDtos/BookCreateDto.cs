using FluentValidation;

namespace BookStoreAPI.DTOs.BookDtos
{
	public class BookCreateDto
	{
        public string Name { get; set; }
        public double Price { get; set; }
        public double CostPrice { get; set; }
    }

    public class BookCreateDtoValidator : AbstractValidator<BookCreateDto>
    {
        public BookCreateDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotNull().WithMessage("Null ola bilmez!")
                .NotEmpty().WithMessage("Bos ola bilmez!")
                .MaximumLength(200).WithMessage("Max 200 ola biler!")
                .MinimumLength(3).WithMessage("Min 3 ola biler!");

            RuleFor(x => x.Price).NotNull().WithMessage("Null ola bilmez!");
			RuleFor(x => x.CostPrice).NotNull().WithMessage("Null ola bilmez!");

            RuleFor(x => x).Custom((x, context) =>
            {
                if (x.CostPrice > x.Price)
                {
                    context.AddFailure("CostPrice", "Price'dan boyuk ola bilmez!");
                }
            });
		}
    }
}
