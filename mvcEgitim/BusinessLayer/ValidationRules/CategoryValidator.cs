using EntityLayer1.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girin");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla karakter girmeyin");
        }

        //public ValidationResult Validate(Category p)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
