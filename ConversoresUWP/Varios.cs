using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace ConversoresUWP
{
    namespace Colores
    {
        public class ColorToBrush : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
                => new SolidColorBrush((Color)value);

            public object ConvertBack(object value, Type targetType, object parameter, string language)
                => throw new NotImplementedException();
        }
    }
}
