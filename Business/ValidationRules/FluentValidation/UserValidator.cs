﻿using Core.Entities.Concrete;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().MinimumLength(2);
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty().MinimumLength(2);
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.PasswordHash).NotEmpty().Equal(x => x.PasswordHash);
            //RuleFor(u => u.PasswordHash).MinimumLength(6).WithMessage("Şifre 6 karakterden az olmamalı.");
            //RuleFor(u => u.PasswordHash).Matches("[A-Z]").WithMessage("Şifreniz en az bir büyük harf içermelidir."); 
            //RuleFor(u => u.PasswordHash).Matches("[a-z]").WithMessage("Şifreniz en az bir küçük harf içermelidir.");
            //RuleFor(u => u.PasswordHash).Matches("[0-9]").WithMessage("Şifreniz en az bir rakam içermelidir.");
            //RuleFor(u => u.PasswordHash).Matches("[^a-zA-Z0-9]").WithMessage("Şifreniz en az bir char karakter içermelidir.");
            RuleFor(u => u.Email).EmailAddress();
        }

    }

}
