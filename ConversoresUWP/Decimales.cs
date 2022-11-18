using System;
using Windows.UI.Xaml.Data;

namespace ConversoresUWP
{
    namespace Decimales
    {
        public class DecToStr_SepMil_2Dec : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
                => ((float)value).ToString("#,##0.00");

            public object ConvertBack(object value, Type targetType, object parameter, string language)
                => throw new NotImplementedException();
        }
        public class DecToStr_SepMil_1DecOpc : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
                => ((float)value).ToString("#,##0.#");

            public object ConvertBack(object value, Type targetType, object parameter, string language)
                => throw new NotImplementedException();
        }
    }
}
