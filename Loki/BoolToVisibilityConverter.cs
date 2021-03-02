using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Loki
{
    public class BoolToVisibilityConverter: IValueConverter
    {

        public Visibility True { get; set; } = Visibility.Visible;
        public Visibility False { get; set; } = Visibility.Hidden;

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool b)
                return b ? True : False;

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
    }
}
