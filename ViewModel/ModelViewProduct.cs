using Namordnik.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Namordnik.OtherClass;
using System.Windows;
using Namordnik.View;
using System.IO;

namespace Namordnik.ViewModel
{
   public class ModelViewProduct : Base
    {
        private ObservableCollection<Product> productlist;
    
        private ObservableCollection<Product> filterProduct;

        private string search="";

        private string pageDisplay;
        
        private int currentPage = 0;
        private int maxPage;
        private int maxRows = 20;
        private int maxRecords;
        private bool orderByDesc;
        private string selectedOrderby;
        private Product selectedProduct;
        private string orderBy;

        private ObservableCollection<string> sortingParams;

        public string PageDisplay
        {
            get => $"{CurrentPage + 1}/{MaxPages}";
        }
        public string Search
        {
            get => search;
            set
            {
                search = value;
               
                OnPropertyChanged("Search");
                OnPropertyChanged("FilterProduct");
            }
        }
        public int CurrentPage
        {
            get => currentPage;
            set
            {
                currentPage = value;
                OnPropertyChanged("CurrentPage");
                OnPropertyChanged("FilterProduct");
            }
        }
        public int MaxRecords
        {
            get
            {
                if (Search != "" || Search is null)

                {
                    return productlist.Where(p => p.name_product.Contains(Search)).ToList().Count;

                }
                else return productlist.Count;

            }
           
        }
        public int MaxRows
        {
            get => maxRows;
            set
            {
                maxRows = value;
                OnPropertyChanged();
            }
        }
        public int MaxPages
        {
            get => (int)(Math.Ceiling((float)MaxRecords / (float)MaxRows));
            set { { maxPage = value; OnPropertyChanged(); } }
        }
        
        public string OrderBy
        {
            get => orderBy;
            set
            {
                orderBy = value;
                Sort(SelectedOrderBy);
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Product> Productlist
        {
            get => productlist;
            set
            {
                productlist = value;
                OnPropertyChanged("Productlist");

            }
        }

        public ObservableCollection<Product> FilterProduct
        {
            get
            {
                OnPropertyChanged("PageDisplay");
                return new ObservableCollection<Product>(Productlist.Skip(CurrentPage * MaxRows).Take(MaxRows).Where(da => da.name_product.Contains(Search)));
            

            }
            set
            {
                filterProduct = value;
                OnPropertyChanged("FilterProduct");

            }
        }

      

        private RelayCommand nextPage;
        private RelayCommand previousPage;

        public ObservableCollection<string> SortingParams
        {
            get => sortingParams;
            set
            {
                sortingParams = value;
                OnPropertyChanged();
            }
        }

        public bool OrderByDesc
        {
            get => orderByDesc;
            set
            {
                orderByDesc = value;
                Sort(SelectedOrderBy);
                OnPropertyChanged("FilterProduct");
            }
        }
        public string SelectedOrderBy
        {
            get => selectedOrderby;
            set
            {
                selectedOrderby = value;
                Sort(SelectedOrderBy);
                OnPropertyChanged("FilterProduct");
            }
        }

        // На следующию страницу
        public RelayCommand NextPage
        {
            get
            {
                return nextPage ?? (nextPage = new RelayCommand(obj =>
                {
                    if(CurrentPage<MaxPages-1 && MaxRecords > MaxRows)
                    {
                        CurrentPage++;
                    }
                }));
            }
        }
        //Вернуться на прошлую страницу
        public RelayCommand PreviousPage
        {
            get
            {
                return previousPage ?? (previousPage = new RelayCommand(obj =>
                {
                    if (CurrentPage > 0)
                    {
                        CurrentPage--;
                    }
                    return;
                }));
            }
        }
        
        public Product SelectedProduct
        {
            get => selectedProduct;
            set
            {
                selectedProduct = value;
                OnPropertyChanged("SelectedProduct");
            }
        }

        private RelayCommand addCommand;
        //Открытие формы добавления
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ?? (addCommand = new RelayCommand(obj =>
                {
                    AddProduct add = new AddProduct();
                    add.ShowDialog();
                    if (add.DialogResult == true)
                    {
                        using(var bd = new up_shopEntities11())
                        {
                            productlist = new ObservableCollection<Product>(bd.Product.ToList());
                            FilterProduct = productlist;
                            OnPropertyChanged("FilterProduct");
                        }

                        
                    }
                    
                }));
            }
        }
        //Загрузка данных
        public ModelViewProduct()
        {
            using (var bd = new up_shopEntities11())
            {
                productlist = new ObservableCollection<Product>(bd.Product.ToList());

                foreach (var item in productlist)
                {
                    bd.Entry(item).Collection("MaterialsProduct").Load();




                }
                FilterProduct = productlist;
                SortingParams = new ObservableCollection<string>();
                SortingParams.Add("Название");
                SortingParams.Add("Номер производственного цеха");
                SortingParams.Add("Минимальная стоимость для агента");

            }
        } 

        private RelayCommand removeProduct;

        public RelayCommand RemoveProduct
        {
            get
            {
                return removeProduct ?? (removeProduct = new RelayCommand(obj =>
                {
                    if (SelectedProduct != null)
                    {
                        try
                        {
                            using(var bd= new up_shopEntities11())
                            {
                                bd.Product.Remove(bd.Product.Where(p=>p.name_product.Equals(SelectedProduct.name_product)).FirstOrDefault());
                                FilterProduct.Remove(SelectedProduct);
                                File.Delete(@"../../products/" + SelectedProduct);
                                MessageBox.Show("Продукт удален","круто", MessageBoxButton.OK);
                                bd.SaveChanges();
                                SelectedProduct = null;
                                productlist = new ObservableCollection<Product>(bd.Product.ToList());
                                FilterProduct = productlist;
                                OnPropertyChanged("FilterProduct");

                            }
                        }
                        catch
                        {
                            MessageBox.Show("Выберите продукт","Сообщение", MessageBoxButton.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Сначала выберите продукт!", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }

                }));
            }
           
        }

        private RelayCommand editcommand;
        public RelayCommand EditCommand
        {
            get
            {
                return editcommand ?? (editcommand = new RelayCommand(obj =>
                {
                    EditProduct ed = new EditProduct(obj as Product);
                    ed.ShowDialog();
                    if (ed.DialogResult == true)
                    {
                        Productlist[Productlist.IndexOf(SelectedProduct)] = (ed.DataContext as EdditViewModel).productsredakt;
                        MessageBox.Show("Продукт успешно изменен", "Сообщение", MessageBoxButton.OK);
                        FilterProduct = Productlist;
                        using (var bd = new up_shopEntities11())
                        {
                            productlist = new ObservableCollection<Product>(bd.Product.ToList());
                            FilterProduct = productlist;
                            OnPropertyChanged("FilterProduct");
                        }

                    }
                }));
            }
        }

        private void Sort(string sortBy)
        {
            if (!String.IsNullOrEmpty(sortBy))
            {
                switch (sortBy)
                {
                    case "Название":
                     {
                            if (!OrderByDesc)
                            {
                                Productlist = new ObservableCollection<Product>(from p in Productlist orderby p.name_product select p);
                            }
                            else
                            {
                                Productlist = new ObservableCollection<Product>(Productlist.OrderByDescending(p => p.name_product));
                            }
                     }
                     break;
                    case "Номер производственного цеха":
                        {
                            if (!OrderByDesc)
                            {
                                Productlist = new ObservableCollection<Product>(from p in Productlist orderby p.number_proizv select p);
                            }
                            else
                            {
                                Productlist = new ObservableCollection<Product>(Productlist.OrderByDescending(p => p.number_proizv));
                            }
                        }
                        break;
                    case "Минимальная стоимость для агента":
                        {
                            if (!OrderByDesc)
                            {
                                Productlist = new ObservableCollection<Product>(Productlist.OrderBy(p=>p.min_cost));
                            }
                            else
                            {
                                Productlist = new ObservableCollection<Product>(Productlist.OrderByDescending(p => p.min_cost));
                            }
                        }
                        break;

                }
            }
      
        }
       
   }
   
}
