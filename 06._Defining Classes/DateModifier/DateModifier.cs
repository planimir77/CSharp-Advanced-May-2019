using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class DateModifier
    {
        private DateTime date1;
        private DateTime date2;
        private int[] fromDate;
        private int[] toDate;

        public DateModifier(int[] arr1,int [] arr2)
        {
            this.fromDate = arr1;
            this.toDate = arr2;
        }

        public DateTime Date1 { get; set; }

        public DateTime Date2 { get; set; }

        public int GetDaysBetweenDates()
        {
            this.Date1 = new DateTime(fromDate[0],fromDate[1],fromDate[2]);
            this.Date2 = new DateTime(toDate[0], toDate[1], toDate[2]);

            return Math.Abs((Date1-Date2).Days);
        }
    }
}
