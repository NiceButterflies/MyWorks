using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RIS_lab5.Model;
using System.Windows.Input;
using System.Windows;
using RIS_lab5.Utils;
using System.ComponentModel;

namespace RIS_lab5.ViewModel
{
    class ShowBalanceViewModel : INotifyPropertyChanged
    {
        public SaleCardModel SaleCard { get; set; }
        public List<SaleCardModel> SaleCards { get; set; }
        private XMLParser xmlp;
        public event PropertyChangedEventHandler PropertyChanged;

        public ShowBalanceViewModel()
        {
            ClickCommand = new Command(arg => findBalance());
            SaleCard = new SaleCardModel { Discount=15, Name="", Surname="",Number=0, Balance=0 };
            SaleCards = XMLParser.GetAllSaleCards();
           
            xmlp = new XMLParser();
        }

        public ICommand ClickCommand { get; set; }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public void findBalance()
        {
       
            foreach (SaleCardModel card in SaleCards)
            {
                if (card.Number.Equals(SaleCard.Number))
                {
                    SaleCard.Balance = card.Balance;
                }
            }

            OnPropertyChanged("");
        }
    }

}
