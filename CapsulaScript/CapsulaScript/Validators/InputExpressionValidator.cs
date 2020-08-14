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
            if ((Regex.IsMatch(tempInStr, @"^((([KNS]|[1-9][1-9])(\+([KNS]|[1-9][1-9]))*)?(,(([KNS]|[1-9][1-9])(\+([KNS]|[1-9][1-9]))*)?)*)?$")) && ValidatePassedInput(tempInStr))
            {
                return ValidationResult.ValidResult;
            }
            else
            {
                return new ValidationResult(false, $"Revise el formato de la expresión, sólo 1 tamaño de letra por palabra");
            }
        }

        private bool ValidatePassedInput(string tempIn)
        {
            foreach(string s in tempIn.Split(','))
            {
                if (!new Regex("^([^1-9]*[1-9][1-9][^1-9]*|[^1-9]*)$").IsMatch(s))
                    return false;
            }
            return true;
        }
    }
}
