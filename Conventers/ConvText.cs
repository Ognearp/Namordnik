using Namordnik.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Namordnik.Conventers
{
    class ConvText : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value != null && ((ICollection<MaterialsProduct>)value).Count != 0)
            {
                var items = value as ICollection<MaterialsProduct>;
                string materials = string.Empty;
                foreach (var item in items)
                {
                    materials += $"{item.name_material} ";
                }
                return materials;
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
