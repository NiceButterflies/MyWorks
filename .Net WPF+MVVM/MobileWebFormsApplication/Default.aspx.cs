using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MobileWebFormsApplication.MobileService1;
using MobileWebFormsApplication.Models;

namespace MobileWebFormsApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            questionnaire quest = new questionnaire();
            quest.sex = Sex.Text;
            quest.age = Convert.ToInt32(Age.Text);
            quest.profession = Profession.Text;
            quest.income = Convert.ToInt32(Income.Text);
            quest.mobile_existence = 0;
            if (MobileExistence.Text.Equals("&nbspда"))
                quest.mobile_existence = 1;
            quest.brand = Brand.Text;
            quest.price = Convert.ToInt32(Price.Text);
            quest.OS = OS.Text;
            quest.furniture = 0;
            if (Furniture.Text.Equals("&nbspда"))
                quest.furniture = 1;
            quest.read = 0;
            if (Read.Text.Equals("&nbspда"))
                quest.read = 1;
            

            MobileServiceClient client = new MobileServiceClient();
            client.addQuestionnaire(quest);


        }
    }
}