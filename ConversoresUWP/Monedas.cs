using System;
using Windows.UI.Xaml.Data;

namespace ConversoresUWP
{
    namespace Monedas
    {
        /*
        public class FloatToEuro_SepMil_2Dec : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
                => ((float)value).ToString("#,##0.00 €");

            public object ConvertBack(object value, Type targetType, object parameter, string language)
                => throw new NotImplementedException();
        }
        */

        public class FloatToEuro_SepMil_2Dec : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
            {
                if (value == null)
                    return null;
                else
                    return ((float)value).ToString("#,##0.00 €");
            }

            public object ConvertBack(object value, Type targetType, object parameter, string language)
                => throw new NotImplementedException();
        }
    }
}
