using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace appDataGrid
{

    public class ButtonBackgroungConvert : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, string language)
        {
            string St = (string)value;
            var bc = new SolidColorBrush();

            switch (St)
            {
                case "I":
                    bc = new SolidColorBrush(Colors.Red);
                    break;
                case "S":
                    bc = new SolidColorBrush(Colors.Yellow);
                    break;
                case "R":
                    bc = new SolidColorBrush(Colors.Blue);
                    break;
                case "N":
                    bc = new SolidColorBrush(Colors.Green);
                    break;

                default:
                    bc = new SolidColorBrush(Colors.Gold);
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
