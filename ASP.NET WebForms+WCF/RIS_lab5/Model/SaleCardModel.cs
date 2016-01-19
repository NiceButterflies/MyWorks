using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using RIS_lab5.Utils;

namespace RIS_lab5.Model
{
    class SaleCardModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
        private int discount;
        public int Discount 
        {
            get { return discount; }
            set
            {
                discount = value;
            }
        }
        private int number;
        public int Number
        {
            get { return number; }
            set
            {
                number = value;
                OnPropertyChanged("");
            }
        }
        private String surname;
        public String Surname
        {
            get { return surname; }
            set
            {
                surname = value;
                OnPropertyChanged("");
            }
        }
        private String name;
        public String Name 
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("");
            }
        }
        public float Balance { get; set; }

        public SaleCardModel()
        {
            this.Discount = 15;
        }

        public SaleCardModel(int number, String surname, String name)
        {
            this.Discount = 15;
            this.Number = number;
            this.Surname = surname;
            this.Name = name;
            Balance = 0;
        }

        public SaleCardModel(int number, String surname, String name, float balance)
        {
            this.Discount = 15;
            this.Number = number;
            this.Surname = surname;
            this.Name = name;
            this.Balance = balance;
        }

        public int NewNumber
        {
            get
            {
                if (name != "")
                {
                    Random rand = new Random();
                    do
                    {
                        El_Gamal.p = rand.Next(10, 10000000);
                    } while (!El_GamalGenerator.isSimple(El_Gamal.p));


                    Random random = new Random();
                    byte[] bytes = new byte[64];
                    random.NextBytes(bytes);
                    bytes[bytes.Length - 1] &= (byte)0x7F; //force sign bit to positive
                    BigInteger p = new BigInteger(bytes);
                    El_Gamal.G = El_GamalGenerator.generateG(El_Gamal.p);
                    El_Gamal.X = El_GamalGenerator.generateX(El_Gamal.p);
                    El_Gamal.Y = El_GamalGenerator.generateY(El_Gamal.G, El_Gamal.X, El_Gamal.p);
                    El_Gamal.K = El_GamalGenerator.generateK(El_Gamal.p);
                    number=El_Gamal.shifr(name, El_Gamal.p, El_Gamal.G, El_Gamal.Y, El_Gamal.X, El_Gamal.K);
                    return number;
                }
                else return 0;
            }
            set { number = value; }
        }
        public virtual float sumOfDiscount(float price)
        {
            return price * Discount / 100;
        }

        public void refreshBalance(float price)
        {
            this.Balance += sumOfDiscount(price);
        }

        public void refreshBalance(float price, float sumOfCut)
        {
            this.Balance -= sumOfCut;
            refreshBalance(price);
        }
    }
}
