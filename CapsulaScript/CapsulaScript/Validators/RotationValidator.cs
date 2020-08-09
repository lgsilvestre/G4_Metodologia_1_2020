using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CapsulaScript.Validators
{
    public class RotationValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if (Regex.IsMatch((string)value, @"^[1-9]\d*$"))
            {
                int v = Convert.ToInt32(value);
                if (v >= 0 && v < 360)
                {
                    return ValidationResult.ValidResult;
                }
                else
                {
                    return new ValidationResult(false, $"Valor entre 0 y 359");
                }
            }
            else
            {
                return new ValidationResult(false, $"Solo numeros reales");
            }
        }
    }
}
