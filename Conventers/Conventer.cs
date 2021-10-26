using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Namordnik.Conventers
{
    class Conventer : IValueConverter
    {

        public object Convert(object value,Type targetType,object parametr,CultureInfo culture)
        {
            if (value != null)
            {
                string path = @"../../" + value as string;
                byte[] bitmapImage = null;

                bitmapImage = File.ReadAllBytes(path);

                return bitmapImage;
            }
            else
            {
               
               string path = @"../../products/picture.png";
                byte[] bitmapImage = null;

                bitmapImage = File.ReadAllBytes(path);

                return bitmapImage;
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
