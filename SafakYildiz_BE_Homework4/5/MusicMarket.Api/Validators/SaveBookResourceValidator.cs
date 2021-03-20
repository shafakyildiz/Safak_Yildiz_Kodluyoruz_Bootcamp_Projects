using FluentValidation;
using MusicMarket.Api.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicMarket.Api.Validators
{
    public class SaveBookResourceValidator: AbstractValidator<SaveBookDTo>
    {
        public SaveBookResourceValidator()
        {
            RuleFor(m => m.Name)
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(m => m.ArtistId)
                .NotEmpty()
                .WithMessage("'Book Id' must not be 0.");
        }
    }
}
