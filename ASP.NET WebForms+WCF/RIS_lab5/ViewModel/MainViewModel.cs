using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RIS_lab5.Utils;
using RIS_lab5.Model;
using System.ComponentModel;
using System.Windows.Input;

namespace RIS_lab5.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<SaleCardModel> SaleCards { get; set; }
        public SaleCardModel ChoosedCard { get; set; }
        public ICommand UpdateWindow { get; set; }

        public MainViewModel()
        {

            SaleCards = XMLParser.GetAllSaleCards();
            ChoosedCard = new SaleCardModel();
            UpdateWindow = new Command(arg => UpdateWindowMethod());
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void UpdateWindowMethod()
        {
            SaleCards = XMLParser.GetAllSaleCards();
            OnPropertyChanged("");
        }

    }
}
