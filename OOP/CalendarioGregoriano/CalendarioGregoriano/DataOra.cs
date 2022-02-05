using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarioGregoriano
{
    internal class DataOra : Data
    {
        private int hour;
        private int minute;
        private int second;

        public DataOra(int yearObj, int monthObj, int dayObj, int hourObj, int minuteObj, int secondObj)
        {
            year = yearObj;
            month = monthObj;
            day = dayObj;
            hour = hourObj;
            minute = minuteObj;
            second = secondObj;
        }
        public override string ToString()
        {
            string strDate = "";
            strDate = day.ToString() + "/" + month.ToString() + "/" + year.ToString()+"    "+hour.ToString()+":"+minute.ToString()+":"+second.ToString();
            return strDate;
        }
        /*public virtual int[] LeggiYMD()
        {
            int[] date = new int[6];
            date[0] = year;
            date[1] = month;
            date[2] = day;
            date[3] = hour;
            date[4] = minute;
            date[5] = second;
            return date;
            
        }*/
        public virtual void Scrivi(int hourObj, int minuteObj, int secondObj)
        {
            hour=hourObj;
            minute=minuteObj;
            second=secondObj;
        }
    }
}
