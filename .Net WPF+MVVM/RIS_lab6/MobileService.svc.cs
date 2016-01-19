using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RIS_lab6
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MobileService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MobileService.svc or MobileService.svc.cs at the Solution Explorer and start debugging.
    public class MobileService : IMobileService
    {
        MobileQuestionnaireEntities1 context = new MobileQuestionnaireEntities1();

        public void addQuestionnaire(questionnaire quest)
        {
            context.Entry(quest);
            context.questionnaire.Add(quest);
            context.SaveChanges();
        }

        public int statRead()
        {
            int count = 0;
            foreach (questionnaire q in context.questionnaire)
            {
                if (q.read == 1)
                {
                    count++;
                }
            }
            return count;
        }

        public int statPrice()
        {
            int sum = 0;
            int count = 0;
            foreach (questionnaire q in context.questionnaire)
            {
                sum += Int32.Parse(q.price.ToString());
                count++;
            }
            return sum / count;
        }

        public int[] statOS()
        {
            int []mas = new int[4];
            int os1 = 0, os2 = 0, os3 = 0, os4 = 0;

            foreach (questionnaire q in context.questionnaire)
            {
                if (q.OS.Equals("Android"))
                {
                    os1++;
                }
                else
                {
                    if (q.OS.Equals("iOS"))
                    {
                        os2++;
                    }
                    else
                    {
                        if (q.OS.Equals("WindowsPhone"))
                        {
                            os3++;
                        }
                        else { os4++; }
                    }
                }
                    
            }

            mas[0] = os1;
            mas[1] = os2;
            mas[2] = os3;
            mas[3] = os4;
     
            return mas;
        }
    }
}
