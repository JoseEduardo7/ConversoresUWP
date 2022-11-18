using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace ConversoresUWP
{
    namespace Booleanos
    {
        public class BoolToVisibility : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
                => (bool)value ? Visibility.Visible : Visibility.Collapsed;

            public object ConvertBack(object value, Type targetType, object parameter, string language)
                => throw new NotImplementedException();
        }
        public class BoolToVisibility_Invertido : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
                => !(bool)value ? Visibility.Visible : Visibility.Collapsed;

            public object ConvertBack(object value, Type targetType, object parameter, string language)
                => throw new NotImplementedException();
        }
        public class Bool_Invertido : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
            {
                return !(bool)value;
            }

            public object ConvertBack(object value, Type targetType, object parameter, string language)
                => throw new NotImplementedException();
        }
    }
}
