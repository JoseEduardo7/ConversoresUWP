using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace ConversoresUWP
{
    namespace Objetos
    {
        public class ObjToBool : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
                => value != null;

            public object ConvertBack(object value, Type targetType, object parameter, string language)
                => throw new NotImplementedException();
        }
        public class ObjToBool_Invertido : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
                => value == null;

            public object ConvertBack(object value, Type targetType, object parameter, string language)
                => throw new NotImplementedException();
        }
        public class ObjToVisibility : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
                => value == null ? Visibility.Collapsed : Visibility.Visible;

            public object ConvertBack(object value, Type targetType, object parameter, string language)
                => throw new NotImplementedException();
        }
        public class ObjToVisibility_Invertido : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
                => value == null ? Visibility.Visible : Visibility.Collapsed;

            public object ConvertBack(object value, Type targetType, object parameter, string language)
                => throw new NotImplementedException();
        }
    }
}
