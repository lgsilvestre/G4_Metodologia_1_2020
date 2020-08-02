﻿using System;
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
            var regex = new Regex(@"^([-+]?\d+),\s*([-+]?\d+)$");
            var match = regex.Match((string)value);
            if (match.Success)
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
