using Microsoft.Win32;
using Namordnik.Model;
using Namordnik.OtherClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Namordnik.ViewModel
{
   public  class AddViewModel : Base
   {
      

        private string nameprod;
        private string articul;
        private double costforagent;
        private string image=@"\products\picture.png";
        private string tipproduct;
        private int matforproizv;
        private int numberproizv;
        
        private bool? dialogResult;

        public string Nameprod
        {
            get => nameprod;
            set
            {
                nameprod = value;
                OnPropertyChanged();
            }
        }

        public string Articul
        {
            get => articul;
            set
            {
                articul = value;
                OnPropertyChanged();
            }
        }

        public double Costforagent
        {
            get => costforagent;
            set
            {
                costforagent = value;
                OnPropertyChanged();
            }
        }

        public string Image
        {
            get => image;
            set
            {
                image = value;
                OnPropertyChanged();
            }
        }

        public string Tipproduct
        {
            get => tipproduct;
            set
            {
                tipproduct = value;
                OnPropertyChanged();
            }
        }

        public int Matforproizv
        {
            get => matforproizv;
            set
            {
                matforproizv = value;
                OnPropertyChanged();
            }
        }

        public int Numberproizv
        {
            get => numberproizv;
            set
            {
                numberproizv = value;
                OnPropertyChanged();
            }
        }

      

        public bool? DialogResult
        {
            get => dialogResult;
            set
            {
                dialogResult = value;
                OnPropertyChanged();
            }
        }

        private RelayCommand addCommand;
        private Product products;
        private RelayCommand loadkartinka;
        //Добавление продукта
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ?? (addCommand = new RelayCommand(obj =>
                {
                    products = new Product
                    {
                        name_product = Nameprod,
                        articul = Articul,
                        min_cost = Costforagent,
                        kol_for_proizv = Matforproizv,
                        images = Image,
                        tip_product = Tipproduct,
                        number_proizv = Numberproizv,
                      
                   
                      

                    };
                    using(var entiteis = new up_shopEntities11())
                    {
                        entiteis.Product.Add(products);
                        entiteis.SaveChanges();
                        DialogResult = true;
                    }
                  
                }));
            }
        }
        // Загрузка картинку
        public RelayCommand LoadKartinka
        {
            get
            {
                   return loadkartinka ?? (loadkartinka = new RelayCommand(obj =>
                   {
                       OpenFileDialog openFileDialog = new OpenFileDialog();
                       openFileDialog.Filter = "Images files(*.PNG,*.JPG)|*.png;*.jpg";
                       if (openFileDialog.ShowDialog() == true)
                       {
                           if (!(File.Exists(@"..\..\products\" + openFileDialog.SafeFileName)))

                          File.Copy(openFileDialog.FileName, System.IO.Path.Combine(@"..\..\products\", openFileDialog.SafeFileName), true);
                           ImageSource img;
                           using(var stream = new FileStream(openFileDialog.FileName, FileMode.Open))
                           {
                               img = BitmapFrame.Create(stream, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                               Image = @"\products\" + openFileDialog.SafeFileName;
                           }

                       }

                   }));
            }
        }


    }
}
