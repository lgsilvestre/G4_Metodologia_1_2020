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
    public class InputExpressionValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string tempInStr = (string)value;
            if (Regex.IsMatch(tempInStr, @"^((([KNS]|1[1-4])(\+([KNS]|1[1-4]))*)?(,(([KNS]|1[1-4])(\+([KNS]|1[1-4]))*)?)*)?$"))
            {
                return ValidationResult.ValidResult;
            }
            else
            {
                return new ValidationResult(false, $"Revise el formato de la expresión");
            }
        }
    }
}
