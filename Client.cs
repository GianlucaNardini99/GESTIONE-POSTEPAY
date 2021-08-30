using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GESTIONE_POSTEPAY
{
    public class Client
    {
        public String Name { get; set; }
        public String Surname { get; set; }
        public DateTime BirthdayDate { get; set; }
        public String Sex { get; set; }
        public String BirthPlace { get; set; }
        public String TelNumber { get; set; }
        public String CardNumber { get; set; }
        public List<DateTime> DateList { get; set; }
        public List<float> EuroList { get; set; }

        // setting client fields 
        public Client(String name, String surname, DateTime bDate, String sex, String bPlace, String tNumber, String cNumber, float euro)
        {
            this.Name = name;
            this.Surname = surname;
            this.BirthdayDate = bDate;
            this.Sex = sex;
            this.BirthPlace = bPlace;
            this.TelNumber = tNumber;
            this.CardNumber = cNumber;
            this.DateList = new List<DateTime>();
            this.EuroList = new List<float>();
            this.EuroList.Add(euro);
        }

        // method that returns the last date of datelist
        public DateTime LastDate(List<DateTime> list)
        {
            return list[(list.Count - 1)];
        }

        // method that returns the last amount of euros of the list
        public float LastEuro(List<float> list)
        {
            return list[(list.Count - 1)];
        }

        // method that search and returns the minimum amount of euros of the list
        public float FindMinimumEuro()
        {
            float actual;
            float minimum = 0;
            float minL = 3000;
            for (int i = 0; i < this.EuroList.Count; i++)
            {
                actual = this.EuroList[i];
                if (actual < minL)
                {
                    minL = actual;
                    minimum = actual;
                }
            }
            return minimum;
        }
    }
}
