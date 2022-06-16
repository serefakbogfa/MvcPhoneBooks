using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class RecordsValidator: AbstractValidator<Records>
    {
        public RecordsValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("You cannot leave the registration Name blank!");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("You cannot leave the registration Surname blank!");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz!");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Please enter at least 3 characters!");
            RuleFor(x => x.SurName).MinimumLength(3).WithMessage("Please enter at least 3 characters!");
            RuleFor(x => x.PhoneNumber).MaximumLength(11).WithMessage("Please do not enter more than 11 characters!");
        }
    }
}
