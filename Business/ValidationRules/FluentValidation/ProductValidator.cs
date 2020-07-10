using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
	public class ProductValidator : AbstractValidator<Product>
	{
		public ProductValidator()
		{
			RuleFor(product => product.ProductName).NotEmpty();
			RuleFor(product => product.ProductName).Length(2, 30);
		}
	}
}
