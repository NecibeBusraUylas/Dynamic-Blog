﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.ContactUserName).NotEmpty().WithMessage("Ad soyad boş geçilemez.");
            RuleFor(x => x.ContactUserName).MinimumLength(2).WithMessage("Ad 2 harften az olamaz.");
            RuleFor(x => x.ContactMail).NotEmpty().WithMessage("E-mail adresi boş geçilemez.");
            RuleFor(x => x.ContactMail).EmailAddress().WithMessage("Lütfen geçerli bir E-Mail adresi giriniz.");
            RuleFor(x => x.ContactSubject).NotEmpty().WithMessage("Başlık boş geçilemez.");
            RuleFor(x => x.ContactMessage).NotEmpty().WithMessage("Mesaj boş geçilemez.");
        }
    }
}