using FluentValidation;
using MusicMarket.Api.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicMarket.Api.Validators
{
    public class SaveLibraryResourceValidator: AbstractValidator<SaveLibraryDTO>
    {
        public SaveLibraryResourceValidator()
        {
            RuleFor(a => a.Name)
              .NotEmpty()
              .MaximumLength(50);
        }
    }
}
