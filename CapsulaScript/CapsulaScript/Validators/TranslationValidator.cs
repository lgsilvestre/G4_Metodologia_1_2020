using CapsulaScript.Model;
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
    public class TranslationValidator : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            var regex = new Regex(@"^\s*([-+]?\d+)\s*,\s*([-+]?\d+)\s*$");
            var match = regex.Match((string)value);
            if (match.Success)
            {
                if (!IsInsideCanvas(value))
                {
                    return new ValidationResult(false, $"El centro de las palabras sale del canvas");
                }

                return ValidationResult.ValidResult;
            }
            else
            {
                return new ValidationResult(false, $"Respetar formato X,Y");
            }
        }
        private bool IsInsideCanvas(object value)
        {
            double x = Convert.ToDouble(((string)value).Split(',')[0]);
            double y = Convert.ToDouble(((string)value).Split(',')[1]);
            if (x < Globals.canvasWidth/2 && y < Globals.canvasHeight/2) return true;
            return false;
        }
    }
}
