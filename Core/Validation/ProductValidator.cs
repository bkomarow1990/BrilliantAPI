using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DTOS;
using FluentValidation;

namespace Core.Validation
{
    public class ProductValidator : AbstractValidator<ProductDTO>
    {
        public ProductValidator()
        {
            RuleFor(g=> g.Name).NotNull().NotEmpty();
        }
    }
}
