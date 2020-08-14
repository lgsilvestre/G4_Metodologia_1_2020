using System;
using System.Windows;
using System.Windows.Data;

namespace CapsulaScript.Converters
{
    [ValueConversion(typeof(string), typeof(FontStyle))]
    public class StringToFontStyleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            FontStyle fontSt;
            switch (value.ToString())
            {
                case "Normal":
                    fontSt = FontStyles.Normal;
                    break;
                case "Italic":
                    fontSt = FontStyles.Oblique;
                    break;
                default:
                    fontSt = FontStyles.Normal;
                    break;
            }
            return fontSt;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            FontStyle fontSt = (FontStyle)value;
            return fontSt.ToString();
        }
    }
}
