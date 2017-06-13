using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace TourOfHeroes.Converters
{
    public class NullToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var invisible = Visibility.Collapsed;
            if (parameter as string == "Hidden")
                invisible = Visibility.Hidden;

            return value == null ? invisible : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
