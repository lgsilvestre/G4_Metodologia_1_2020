using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace CapsulaScript.Converters
{
    [ValueConversion(typeof(string), typeof(FontWeight))]
    public class StringToFontWeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            FontWeight fontWt;
            switch (value.ToString())
            {
                case "Bold":
                    fontWt = FontWeights.Bold;
                    break;
                case "ExtraBold":
                    fontWt = FontWeights.ExtraBold;
                    break;
                case "Normal":
                    fontWt = FontWeights.Normal;
                    break;
                case "Light":
                    fontWt = FontWeights.Light;
                    break;
                default:
                    fontWt = FontWeights.Normal;
                    break;
            }
            return fontWt;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            FontWeight fontWt = (FontWeight)value;
            return fontWt.ToString();
        }
    }
}
