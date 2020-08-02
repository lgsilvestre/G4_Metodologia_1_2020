using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CapsulaScript.Validators
{
    public class InputTextValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if(Regex.IsMatch((string)value, @"^[A-Za-z\s]+$"))
            {
                return ValidationResult.ValidResult;
            }
            else
            {
                return new ValidationResult(false, $"Solo caracteres alfabéticos");
            }
        }
    }
}
