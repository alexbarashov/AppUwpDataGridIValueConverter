using System;
using Windows.UI.Xaml.Data;

namespace appDataGrid
{
    public class StatusConvert : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, string language)
        {

            string St = (string)value;
            string bc;
            switch (St)
            {
                case "I":
                    bc = "Incom";
                    break;
                case "R":
                    bc = "Rx";
                    break;
                case "S":
                    bc = "Tx";
                    break;
                case "N":
                    bc = "None";
                    break;

                default:
                    bc = "Not";
                    break;
            }

            // Return the month value to pass to the target.
            return bc;
        }

        // ConvertBack is not implemented for a OneWay binding.
        public object ConvertBack(object value, Type targetType,
            object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }


}
