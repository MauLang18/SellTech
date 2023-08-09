using FluentValidation;
using SellTech.Application.Dtos.Categoria.Request;

namespace SellTech.Application.Validators.Categoria
{
    public class CategoriaValidator : AbstractValidator<CategoriaRequestDto>
    {
        public CategoriaValidator()
        {
            RuleFor(x => x.Nombre)
                .NotNull().WithMessage("El campo NOMBRE no puede ser nulo")
                .NotEmpty().WithMessage("El campo NOMBRE no puede estar vacio");
        }
    }
}
