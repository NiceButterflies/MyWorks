using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using RIS_lab5.Model;

namespace RIS_lab5.Utils
{
    class XMLParser
    {
        private const String file = "../../XML/cards.xml";

        public static List<SaleCardModel> GetAllSaleCards()
        {
            XDocument doc = XDocument.Load(file);

            List<SaleCardModel> SaleCards = new List<SaleCardModel>();
            XNode node = doc.Root.FirstNode;

            while (node != null)
            {
                if (node.NodeType == System.Xml.XmlNodeType.Element)
                {
                    SaleCardModel SaleCard = new SaleCardModel();
                    XElement el = (XElement)node;

                    SaleCard.Number = Int32.Parse(el.Element("number").Value);
                    SaleCard.Surname = el.Element("surname").Value;
                    SaleCard.Name = el.Element("name").Value;
                    SaleCard.Balance = Single.Parse(el.Element("balance").Value);
                    SaleCards.Add(SaleCard);
                }
                node = node.NextNode;
            }
            return SaleCards;
        }

        public void AddSaleCard(SaleCardModel SaleCard)
        {
            XDocument doc = XDocument.Load(file);
            XElement card = new XElement("SaleCard",
                new XElement("discount", SaleCard.Discount),
                new XElement("number", SaleCard.Number),
                new XElement("surname", SaleCard.Surname),
                new XElement("name", SaleCard.Name),
                new XElement("balance", SaleCard.Balance));
                
            doc.Root.Add(card);
            doc.Save(file);

        }

        public bool DeleteSaleCard(String field, String value)
        {
            XDocument doc = XDocument.Load(file);
            IEnumerable<XElement> SaleCards = doc.Root.Descendants("SaleCard").Where(
                tmp => tmp.Element(field).Value.Equals(value)).ToList();
            if (SaleCards.Count() != 0)
            {
                foreach (XElement tmp in SaleCards)
                    tmp.Remove();
                doc.Save(file);
                return true;
            }
            else return false;
        }

        public bool UpdateSaleCard(String number, String field, String value)
        {
            XDocument doc = XDocument.Load(file);
            IEnumerable<XElement> SaleCards = doc.Root.Descendants("SaleCard").Where(
                tmp => tmp.Element("number").Value.Equals(number)).ToList();
            if (SaleCards.Count() != 0)
            {
                foreach (XElement tmp in SaleCards)
                    tmp.SetElementValue(field, value);
                doc.Save(file);
                return true;
            }
            else return false;
 

        }
    }
}

