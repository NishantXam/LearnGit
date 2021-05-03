using System;
using System.Globalization;
using Xamarin.Forms;

namespace Poc.Helper.Converters
{
    public class colorConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                string color = string.Empty;
                var data = (string)value;

                switch (data)
                {
                    case "1":
                        color = "#ed0707";
                        break;
                    case "14":
                        color = "#34dgef";
                        break;
                    //case 15:
                    //    color = "#cc34fr";
                    //    break;
                    //case 16:
                    //    color = "#2e15eb";
                    //    break;
                    //case 17:
                    //    color = "#0ff2ea";
                    //    break;
                    //case 18:
                    //    color = "#c3c3c3";
                    //    break;
                    //case 13:
                    //    color = "#000000";
                    //    break;
                    //case 12:
                    //    color = "#cdcdcd";
                    //    break;
                    //case 11:
                    //    color = "#adadad";
                    //    break;

                    default:
                        color = "#000000";
                        break;

                }
                return color;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
