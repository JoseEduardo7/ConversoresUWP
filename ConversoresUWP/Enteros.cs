using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace ConversoresUWP
{
    namespace Enteros
    {
        public class IntToStr_SepMil : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
            {
                switch (Type.GetTypeCode(value.GetType()))
                {
                    case TypeCode.Int16:
                        return ((short)value).ToString("#,##0");

                    case TypeCode.UInt16:
                        return ((ushort)value).ToString("#,##0");

                    case TypeCode.Int32:
                        return ((int)value).ToString("#,##0");

                    case TypeCode.UInt32:
                        return ((uint)value).ToString("#,##0");

                    default:
                        throw new Exception("IntToStr_SepMil");
                }
            }

            public object ConvertBack(object value, Type targetType, object parameter, string language)
                => System.Convert.ToUInt16(((string)value).Replace(",", "").Replace(".", ""));
        }
        public class IntToBool : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
            {
                switch (Type.GetTypeCode(value.GetType()))
                {
                    case TypeCode.Int16:
                        return (short)value == 0 ? false : true;

                    case TypeCode.UInt16:
                        return (ushort)value == 0 ? false : true;

                    case TypeCode.Int32:
                        return (int)value == 0 ? false : true;

                    case TypeCode.UInt32:
                        return (uint)value == 0 ? false : true;

                    default:
                        throw new Exception("IntToBool");
                }
            }

            public object ConvertBack(object value, Type targetType, object parameter, string language)
                => throw new NotImplementedException();
        }
        public class IntToBoolInvertido : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
            {
                switch (Type.GetTypeCode(value.GetType()))
                {
                    case TypeCode.Int16:
                        return (short)value == 0 ? true : false;

                    case TypeCode.UInt16:
                        return (ushort)value == 0 ? true : false;

                    case TypeCode.Int32:
                        return (int)value == 0 ? true : false;

                    case TypeCode.UInt32:
                        return (uint)value == 0 ? true : false;

                    default:
                        throw new Exception("IntToBoolInvertido");
                }
            }

            public object ConvertBack(object value, Type targetType, object parameter, string language)
                => throw new NotImplementedException();
        }

        public class IntToVisibility : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, string language)
                => (int)value == 0 ? Visibility.Collapsed : Visibility.Visible;

            public object ConvertBack(object value, Type targetType, object parameter, string language)
                => throw new NotImplementedException();
        }
    }
   
}
