using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsReviewOOP
{
    public class clsTime
    {
        // Delaration of private fields (variables that store the values of the properties)
        private int vHour;
        private int vMinute;
        private int vSecond;
        // Declaratiom of access methods to the properties
        public int Hour
        {
            get // for reading the value of the feild associated to the property
            {
                return vHour;
            }
            set // for writing the value of the feild associated to the property
            {
                vHour = (value >= 0 && value <= 23) ? value : 0;
            }
        }
        public int Minute
        {
            get // for reading the value of the feild associated to the property
            {
                return vMinute;
            }
            set // for writing the value of the feild associated to the property
            {
                vMinute = (value >= 0 && value <= 59) ? value : 0;
            }
        }
        public int Second
        {
            get // for reading the value of the feild associated to the property
            {
                return vSecond;
            }
            set // for writing the value of the feild associated to the property
            {
                vSecond = (value >= 0 && value <= 59) ? value : 0;
            }
        }


        public void Adjust(int anHour, int aMinute,int aSecond)
        {
           
            Hour = anHour;
            Minute = aMinute;
            Second = aSecond;
        }

        public string DisplayUniversal() 
        {
            string info;
            info = Hour+" :" +Minute + " : " + Second;
            return info;
            
        }
        public string DisplayStandard()
        {
            string stan ="";

            if (Hour <= 12)
            {
                stan= Hour + " :" + Minute + " : " + Second + "AM";
            }
            else if(Hour >12)
            {
               stan= (Hour - 12) + " :" + Minute + " : " + Second + "PM";
            }
            else if (Hour == 12)
            {
                stan = (Hour - 12) + " :" + Minute + " : " + Second + "PM";
            }
            return stan;

            // return ((Hour > 12) ? Hour - 12 : Hour)+":" + Minute + " : " + Second + ((Hour>12)?"PM" : "AM");


        }
        
    }

}
