using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MobileWebFormsApplication.Models;
using MobileWebFormsApplication.MobileService1;

namespace MobileWebFormsApplication
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Statistika_Click(object sender, EventArgs e)
        {
            MobileServiceClient client = new MobileServiceClient();

            if (OS.Checked == true)
            {
                int []mas = new int[4];
                mas = client.statOS();
                Info.Text = "Кол-во пользователей Android: " + mas[0];
                Info1.Text = "Кол-во пользователей iOS: " + mas[1];
                Info2.Text = "Кол-во пользователей WindowsPhone: " + mas[2];
                Info3.Text = "Кол-во пользователей других ОС: " + mas[3];
            }
            if (Read.Checked == true)
            {
                Info.Text = "Для чтения телефон использует " + client.statRead()+ " людей";
                Info1.Text = "";
                Info2.Text = "";
                Info3.Text = "";
            }
            if (Price.Checked == true)
            {
                Info.Text = "Средняя цена, которую люди готовы заплатить за новый мобильный телефон: "+client.statPrice()+"$";
                Info1.Text = "";
                Info2.Text = "";
                Info3.Text = "";
            }
        }
    }
}