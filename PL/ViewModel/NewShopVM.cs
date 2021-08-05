using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PL.Model;

namespace PL.ViewModel
{
    public class NewShopVM : INotifyPropertyChanged
    {
        private NewShopModel NewShopModel;
        public event PropertyChangedEventHandler PropertyChanged;
        
        public NewShopVM()
        {
            NewShopModel = new NewShopModel();
        }
    }
}
