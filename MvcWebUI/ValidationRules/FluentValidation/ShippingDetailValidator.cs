using FluentValidation;
using MvcWebUI.Models;
using System;

namespace MvcWebUI.ValidationRules.FluentValidation
{
    public class ShippingDetailValidator : AbstractValidator<ShippingDetail> 
    {
        public ShippingDetailValidator()
        {
            //FluentValidation
            RuleFor(expression: s => s.FirstName).NotEmpty().WithMessage("Adı Gereklidir");
            RuleFor(expression: s => s.FirstName).MinimumLength(2);
            RuleFor(expression: s => s.LastName).NotEmpty();
            RuleFor(expression: s => s.Address).NotEmpty();
            RuleFor(expression: s => s.Address).NotEmpty();

            RuleFor(expression: s => s.City).NotEmpty().When(predicate: s => s.Age < 18);

            //RuleFor(expression: s => s.FirstName).Must(StartWithA);
        }

        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
