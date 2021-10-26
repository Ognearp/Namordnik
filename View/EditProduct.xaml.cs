using Namordnik.Model;
using Namordnik.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Namordnik.View
{
    /// <summary>
    /// Логика взаимодействия для EditProduct.xaml
    /// </summary>
    public partial class EditProduct : Window
    {
      
        public EditProduct(Product prod)
        {
            InitializeComponent();
            DataContext = new EdditViewModel(prod);
        }
    }
}
