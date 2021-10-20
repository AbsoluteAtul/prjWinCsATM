using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsReviewOOP
{
    public class clsDate
    {
        private int vDay;//0
        private int vMonth;//0
        private int vYear;//0

        public clsDate()      
        {
            vDay = 1;
            vMonth = 1;
            vYear = 1;
        }
        public clsDate(int aDay,int aMonth, int aYear)
        {
            Day = aDay;
            Month = aMonth;
            Year = aYear;
        }

        DateTime dt = DateTime.Today;
        public int Day
        {
            get // for reading the value of the feild associated to the property
            {
                return vDay;
            }
            set // for writing the value of the feild associated to the property
            {
               vDay = (value > 0 && value <= 31) ? value : dt.Day;  //  vDay = (value > 0 && value <= 31) ? value : DateTime.Today.Day;
            }
        }
        public int Month
        {
            get // for reading the value of the feild associated to the property
            {
                return vMonth;
            }
            set // for writing the value of the feild associated to the property
            {
                vMonth = (value > 0 && value <= 12) ? value : dt.Month;// vDay = (value > 0 && value <= 31) ? value : DateTime.Today.Month;

            }
        }
        public int Year
        {
            get // for reading the value of the feild associated to the property
            {
                return vYear;
            }
            set // for writing the value of the feild associated to the property
            {
                vYear = (value > 0 && value <= 2020) ? value : dt.Year; //  vDay = (value > 0 && value <= 31) ? value : DateTime.Today.Year;

            }
        }



        public void Intialize(int aDay, int aMonth, int aYear)
        {
           
           
                Day = aDay;
                Month = aMonth;
                Year = aYear;
            
                
            
        }
        
         
        public string toNumber()
        {
            string info;
            info = Day + " / " + Month + " / " + Year;
            return info;

        }
        public string toLetter()
        {
            //DateTime d = new DateTime(Year, Month, Day);
            //string let;
            //string Name;
           
            //if (Month == 1)
            //{
            //    Name = "January";
            //}
            //else if (Month == 2)
            //{
            //    Name = "Febrary";
            //}
            //else if (Month == 2)
            //{
            //    Name = "Febrary";
            //}
            //else if (Month == 3)
            //{
            //    Name = "March";
            //}
            //else if (Month == 4)
            //{
            //    Name = "April";
            //}
            //else if (Month == 5)
            //{
            //    Name = "May";
            //}
            //else if (Month == 6)
            //{
            //    Name = "June";
            //}
            //else if (Month == 7)
            //{
            //    Name = "July";
            //}
            //else if (Month == 8)
            //{
            //    Name = "August";
            //}
            //else if (Month == 9)
            //{
            //    Name = "September";
            //}
            //else if (Month == 10)
            //{
            //    Name = "October";
            //}
            //else if (Month == 11)
            //{
            //    Name = "November";
            //}
            //else if (Month == 12)
            //{
            //    Name = "December";
            //}

           


            //let = d.DayOfWeek +" "+Day + " of " + Name +" "+ Year;
            //return let;


            string info = "";

            DateTime mydate = new DateTime(Year, Month, Day);
            int indxDayWeek = Convert.ToInt32(mydate.DayOfWeek);
            // Search for the name of the day of the week 
            switch (indxDayWeek)
            {
                case 0:
                    info = "Sunday "; break;
                case 1:
                    info = "Monday "; break;
                case 2:
                    info = "Tuesday "; break;
                case 3:
                    info = "Wednesday "; break;
                case 4:
                    info = "Thursday "; break;
                case 5:
                    info = "Friday "; break;
                case 6:
                    info = "Saturday "; break;
            }

            info += Day + " of ";

            // Search for the name of the month of the year 
            switch (Month)
            {
                case 1:
                    info += "January "; break;
                case 2:
                    info += "February "; break;
                case 3:
                    info += "March "; break;
                case 4:
                    info += "April "; break;
                case 5:
                    info += "May "; break;
                case 6:
                    info += "June "; break;
                case 7:
                    info += "July "; break;
                case 8:
                    info += "August "; break;
                case 9:
                    info += "September "; break;
                case 10:
                    info += "October "; break;
                case 11:
                    info += "November "; break;
                case 12:
                    info += "December "; break;
            }

            info += Year;




            return info;
        }
    }
    
}
  

