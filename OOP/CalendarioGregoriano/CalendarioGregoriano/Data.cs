using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioGregoriano
{
    internal class Data
    {
        //protected DateTime dt;
        protected int day;
        public int GetDay()
        {
            return day;
        }
        protected int month;
        public int GetMonth()
        {
            return month;
        }
        protected int year;
        public int GetYear()
        {
            return year;
        }
        private bool bisestile;

        public Data()
        {
            day = 1;
            month = 1;
            year = 1900;
            bisestile = true;
        }

        public Data(int dayObj, int monthObj, int yearObj)
        {
            day = dayObj;
            month = monthObj;
            year = yearObj;
            bisestile = true;
            if (yearObj % 4 == 0)
            {
                bisestile = true;
            }
            else
            {
                bisestile = false;
            }
        }

        public override string ToString()
        {
            string strDate = "";
            strDate = day.ToString()+"/"+month.ToString()+"/"+year.ToString();
            return strDate;
        }

        public virtual bool IsBisestile()
        {
            return bisestile;
        }

        public virtual void Domani()
        {
            DateTime dt = new DateTime(year, month, day);   
            dt = dt.AddDays(1);
            year = dt.Year;
            month = dt.Month;
            day = dt.Day;
        }

        public virtual void Ieri()
        {
            DateTime dt = new DateTime(year, month, day);
            dt = dt.Subtract(TimeSpan.FromDays(1));
            year = dt.Year;
            month = dt.Month;
            day = dt.Day;
        }
        public virtual string Giorno()
        {
            DateTime dt = new DateTime(year, month, day);
            string str;
            str = dt.ToString("dddd");
            return str;
        }
        public virtual void Scrivi(int yearObj, int monthObj, int dayObj)
        {
            year = yearObj;
            month = monthObj;
            day = dayObj;
        }
        /*public virtual int[] LeggiYMD()
        {
            int[] date = new int[3];
            date[0] = year;
            date[1] = month;
            date[2] = day;
            return date;
        }*/
    }
}
