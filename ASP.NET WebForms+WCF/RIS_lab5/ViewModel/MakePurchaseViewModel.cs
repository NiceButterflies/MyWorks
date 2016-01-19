using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RIS_lab5.Model;
using RIS_lab5.Utils;
using System.Windows;
using System.ComponentModel;
using System.Windows.Input;
using System.IO;

namespace RIS_lab5.ViewModel
{

    class MakePurchaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public SaleCardModel SaleCard { get; set; }
        public List<SaleCardModel> SaleCards { get; set; }
        private XMLParser xmlp;
        private int price;
        private float bonus;
        private float cutBonus;
        private int number;
        private float balance;

        public float NewBalance
        {
            get 
            {
                SaleCard.refreshBalance(price, cutBonus);
                return SaleCard.Balance;
            }
        }

        public float CutBonus 
        {
            get { return cutBonus; }
            set 
            {
                if (value > balance || value > price)
                {
                    MessageBox.Show("Вы не можете снять больше бонусов, чем есть на карте либо снять больше бонусов, чем стоимость покупки!");
                }
                else {
                    cutBonus = value;
                    OnPropertyChanged("NewBalance");
                }
            }
        }

        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public int Number
        {
            set 
            {
                if (areThereThisCard(value))
                {
                    number = value;
                    OnPropertyChanged("Balance");
                    OnPropertyChanged("Bonus");
                }
                else MessageBox.Show("Данная карта не зарегистрирована");
            }
        }
        public float Bonus
        {
            set { bonus = value; }
            get { return SaleCard.sumOfDiscount(price); }
        }
        public int Price
        {
            set { price = value; }
            get { return price; }
        }
        public ICommand ClickCommand { get; set; }

        public MakePurchaseViewModel()
        {
            ClickCommand = new Command(arg => ClickMethod());
            SaleCard = new SaleCardModel { Discount=15, Surname="", Name="", Number=0, Balance=0};
            SaleCards = XMLParser.GetAllSaleCards();
            xmlp = new XMLParser();
        }


        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public bool areThereThisCard(int value)
        {
            foreach (SaleCardModel card in SaleCards)
            {
                if (card.Number==value)
                {
                    SaleCard = card;
                    balance = card.Balance;
                    return true;
                }
            }
            return false;
        }

        private void ClickMethod()
        {
            using (StreamWriter file = File.AppendText("../../report/User.txt"))
            {
                file.WriteLine(SaleCard.Number + " || " + price + " || " + cutBonus + " || " + (price * 0.15));
            }
            xmlp.UpdateSaleCard(SaleCard.Number.ToString(), "balance", SaleCard.Balance.ToString());
            MessageBox.Show("Покупка совершена успешно");

        }
    }

}
