using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace CapsulaScript.Converters
{
    [ValueConversion(typeof(bool), typeof(TextDecoration))]
    public class BoolToUnderlineConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            TextDecoration decoration;
            if ((bool)value)
            {
                return TextDecorations.Underline;
            }
            return "none";
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            //FontStyle fontSt = (FontStyle)value;
            return null;
        }
    }
}
