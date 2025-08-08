using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class HiringDate
    {
        #region Attributes
        private int day;
        private int month;
        private int year;



        #endregion


        #region Property
       

        public int Day
        {
            get { return day; }
            set
            {
                if (value > 1 && value < 31)
                    day = value;
                else
                    Console.WriteLine("Invalid day.");

            }
        }
        public int Month
        {
            get { return month; }
            set
            {
                if (value > 1 && value < 12)
                    month = value;
                else
                    Console.WriteLine("Invalid month.");
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value > 2003 && value < DateTime.Now.Year)
                    year = value;
                else
                    Console.WriteLine("Invalid year.");
            }
        }



        #endregion

        #region Constructor


        public HiringDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        #endregion

        #region Methods

        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
        #endregion



    }
}
