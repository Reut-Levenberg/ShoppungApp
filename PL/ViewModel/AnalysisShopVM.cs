using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PL.Model;

namespace PL.ViewModel
{
    public class AnalysisShopVM : INotifyPropertyChanged
    {
        private AnalysisShopModel AnalysisShopModel;
        public event PropertyChangedEventHandler PropertyChanged;

        public AnalysisShopVM()
        {
            AnalysisShopModel = new AnalysisShopModel();
        }
    }

}
