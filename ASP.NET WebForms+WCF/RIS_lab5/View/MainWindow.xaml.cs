using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RIS_lab5.ViewModel;

namespace RIS_lab5.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var createCard = new CreateSaleCardWindow
            {
                DataContext = new CreateSaleCardViewModel()
            };

            createCard.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var makePurchase = new MakePurchaseWindow
            {
                DataContext = new MakePurchaseViewModel()
            };

            makePurchase.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var showBalance = new ShowBalanceWindow
            {
                DataContext = new ShowBalanceViewModel()
            };
            showBalance.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var mergerCards = new MergerCardsWindow
            {
                DataContext = new MergerCardsViewModel()
            };
            mergerCards.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("D:/Laby/RIS_lab5/RIS_lab5/report/User.txt");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
