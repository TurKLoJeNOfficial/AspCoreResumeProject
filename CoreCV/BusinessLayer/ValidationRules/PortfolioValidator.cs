using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje adını boş bırakamazsınız");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel alanı boş bırakamazsınız");
            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Görsel2 alanı boş bırakamazsınız");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat alanı boş bırakamazsınız");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Değer alanı boş bırakamazsınız");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje adı en az 5 karakterli olmalı");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Proje adı en fazla 50 karakterli olmalı");
        }
    }
}
