using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PL.Model;

namespace PL.ViewModel
{
    public class ShoppingProductsVM : INotifyPropertyChanged
    {
        private ShoppingProductsModel ShoppingProducts;
        public event PropertyChangedEventHandler PropertyChanged;

        public ShoppingProductsVM()
        {
            ShoppingProducts = new ShoppingProductsModel();
        }
    }
}
