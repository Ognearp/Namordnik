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
    public  class EdditViewModel : Base
    {
      

        private string nameproduct;
        private string articul;
        private double costforagent;
        private string image = @"\products\picture.png";
        private string tipproduct;
        private int matforproizv;
        private int numberproizv;
        private bool? dialogResult;
        public Product productsredakt;


        //Передача данных
        public EdditViewModel(Product alo)
        {
            productsredakt = alo;
            Nameproduct = productsredakt.name_product;
            Articul = productsredakt.articul;
            Costforagent = productsredakt.min_cost;
            Tipproduct = productsredakt.tip_product;
            Image = productsredakt.images;
            Matforproizv = productsredakt.kol_for_proizv;
            NumberProizv = productsredakt.number_proizv;
            
        }

        public string Nameproduct
        {
            get => nameproduct;
            set
            {
                nameproduct = value;
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

        public string Tipproduct
        {
            get => tipproduct;
            set
            {
                tipproduct = value;
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

        public int Matforproizv
        {
            get => matforproizv;
            set
            {
                matforproizv = value;
                OnPropertyChanged();
            }
        }

        public int NumberProizv
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

        
        private RelayCommand editcommand;
        
        public RelayCommand EditCommand
        {
            get
            {
                return editcommand ?? (editcommand = new RelayCommand(obj =>{

                using (var bd = new up_shopEntities11())
                {
                    Product product = bd.Product.Where(p => p.articul.Equals(productsredakt.articul)).FirstOrDefault();
                        product.articul = Articul;
                        product.images = Image;
                        product.min_cost = Costforagent;
                        product.tip_product = Tipproduct;
                        product.kol_for_proizv = Matforproizv;
                        product.number_proizv = NumberProizv;
      
                        bd.SaveChanges();
                        DialogResult = true;
                    }
                }));
            }
        }
        private RelayCommand loadKartinka;
        public RelayCommand LoadKartinka
        {
            get
            {
                return loadKartinka ?? (loadKartinka = new RelayCommand(obj => {

                    OpenFileDialog openFildeDialog = new OpenFileDialog();
                    openFildeDialog.Filter="Images files(*.PNG,*.JPG)|*.png;*.jpg";
                    if (openFildeDialog.ShowDialog() == true)
                    {
                        if (!(File.Exists(@"../../products" + openFildeDialog.SafeFileName)))

                      File.Copy(openFildeDialog.FileName, System.IO.Path.Combine(@"/../..products" + openFildeDialog.SafeFileName),true);
                        ImageSource img;
                        using(var stream = new FileStream(openFildeDialog.FileName, FileMode.Open))
                        {
                            img = BitmapFrame.Create(stream, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                            Image = @"/products/" + openFildeDialog.SafeFileName;
                        }

                    }
                }));
            }
        }
     
    }
}
