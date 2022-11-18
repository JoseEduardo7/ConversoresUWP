using System;
using Windows.UI.Xaml.Data;

namespace ConversoresUWP
{
    namespace Fechas
    {
        public class DateToStr_ddMMyy : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
            {
                if (value == null)
                    return null;
                else
                    return ((DateTime)value).ToString("dd/MM/yy");
            }

            public object ConvertBack(object value, Type targetType, object parameter, string language)
                => throw new NotImplementedException();
        }
        public class DateToStr_DiaSemana : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
            {
                if (value == null)
                    return null;
                else
                    return ((DateTime)value).ToString("dddd");
            }

            public object ConvertBack(object value, Type targetType, object parameter, string language)
                => throw new NotImplementedException();
        }
        public class TimeToStr_ddMM_HHmm : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
                => ((DateTime)value).ToString("dd/MM HH:mm");

            public object ConvertBack(object value, Type targetType, object parameter, string language)
                => throw new NotImplementedException();
        }
        public class TimeToStr_ddMMyy_HHmm : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
                => ((DateTime)value).ToString("dd/MM/yy HH:mm");

            public object ConvertBack(object value, Type targetType, object parameter, string language)
                => throw new NotImplementedException();
        }
    }
}
