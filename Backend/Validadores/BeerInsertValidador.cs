using Backend.DTOs;
using FluentValidation;

namespace Backend.Validadores
{
    public class BeerInsertValidador : AbstractValidator<BeerInsertDto>
    {
        public BeerInsertValidador()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("El nombre es obligatorio mi pana 🤷‍♂️🤷‍♂️");
            RuleFor(x => x.Name ).Length(2,20).WithMessage("Nombre de 2 a 20 caracteres por favor");
        }
    }
}

