﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RIS_lab5.Model;
using System.Windows.Input;
using System.Windows;
using RIS_lab5.Utils;

namespace RIS_lab5.ViewModel
{
    class CreateSaleCardViewModel
    {
        public SaleCardModel SaleCard { get; set; }
        public List<SaleCardModel> SaleCards { get; set; }
        private XMLParser xmlp;

        public CreateSaleCardViewModel()
        {
            ClickCommand = new Command(arg => ClickMethod());
            SaleCard = new SaleCardModel { Discount=15, Surname="", Name="", Number=0, Balance=0};
            SaleCards = XMLParser.GetAllSaleCards();
            xmlp = new XMLParser();
        }

        public ICommand ClickCommand { get; set; }

        private void ClickMethod()
        {
           // MessageBox.Show("This is click command");
            foreach (SaleCardModel card in SaleCards)
            {
                if (card.Number.ToString().Equals(SaleCard.Number.ToString()))
                {
                    MessageBox.Show("Данная карта уже существует");
                    return;
                }
            }
           SaleCardModel newCard = new SaleCardModel(SaleCard.Number, SaleCard.Surname, SaleCard.Name);
           xmlp.AddSaleCard(newCard);
           MessageBox.Show("Карта была успешно зарегистрирована");
           
        }
    }
}
