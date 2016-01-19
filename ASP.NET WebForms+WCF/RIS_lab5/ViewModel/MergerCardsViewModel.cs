using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RIS_lab5.Model;
using RIS_lab5.Utils;
using System.Windows.Input;
using System.Windows;
using System.ComponentModel;

namespace RIS_lab5.ViewModel
{
    class MergerCardsViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public SaleCardModel SaleCard { get; set; }
        public List<SaleCardModel> SaleCards { get; set; }
        private XMLParser xmlp;

        private int number1;
        public int Number1
        {
            set
            {
                    if (areThereThisCard(value))
                    {
                        number1 = value;
                        OnPropertyChanged("Balance1");
                    }
                    else MessageBox.Show("Данная карта не существует");
            }
            get { return number1; }
        }

        private int number2;
        public int Number2
        {
            set
            {
                if (areThereThisCard(value))
                {
                    number2 = value;
                    OnPropertyChanged("Balance2");
                }
                else MessageBox.Show("Данная карта не существует");
            }
            get { return number2; }
        }

        private float balance1;
        private float b1;
        public float Balance1
        {
            set { balance1 = value;  }
            get 
            {
                foreach (SaleCardModel card in SaleCards)
                {
                    if (card.Number.ToString().Equals(number1.ToString()))
                    {
                        b1 = card.Balance;
                        OnPropertyChanged("NewBalance");
                        return card.Balance;
                    }
                }
                return 0;
            }
        }

        private float balance2;
        private float b2;
        public float Balance2
        {
            set { balance2 = value; }
            get
            {
                foreach (SaleCardModel card in SaleCards)
                {
                    if (card.Number.ToString().Equals(number2.ToString()))
                    {
                        b2 = card.Balance;
                        OnPropertyChanged("NewBalance");
                        return card.Balance;
                    }
                }
                return 0;
            }
        }

        private float newBalance;
        public float NewBalance
        {
            set { newBalance = value; }
            get
            {
                return b1 + b2;
            }
        }

        public ICommand ClickCommand { get; set; }

        public MergerCardsViewModel()
        {
            ClickCommand = new Command(arg => ClickMethod());
            SaleCard = new SaleCardModel { Discount=15, Surname="", Name="", Number=0, Balance=0};
            SaleCards = XMLParser.GetAllSaleCards();
            xmlp = new XMLParser();
        }

        private void ClickMethod()
        {
            // MessageBox.Show("This is click command");

            foreach (SaleCardModel cards in SaleCards)
            {
                if (cards.Number == Number1)
                {
                    xmlp.DeleteSaleCard("number", Number1.ToString());
                }
                if (cards.Number == Number2)
                {
                    xmlp.DeleteSaleCard("number", Number2.ToString());
                }
            }

            foreach (SaleCardModel card in SaleCards)
            {
                if (card.Number.ToString().Equals(SaleCard.Number.ToString()))
                {
                    MessageBox.Show("Данная карта уже существует");
                    return;
                }
            }
            SaleCardModel newCard = new SaleCardModel(SaleCard.Number, SaleCard.Surname, SaleCard.Name, NewBalance);
            xmlp.AddSaleCard(newCard);
            MessageBox.Show("Карта была успешно зарегистрирована");

        }

        public bool areThereThisCard(int value)
        {
            foreach (SaleCardModel card in SaleCards)
            {
                if (card.Number == value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
