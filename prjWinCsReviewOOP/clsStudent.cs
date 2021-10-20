using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsReviewOOP
{
    class clsStudent
    {
        // declare a field
        private string vNumber;
        private string vName;
        private Single vGrade;
        private clsDate vBirthday;
        // do not declare age because it does not store a value
        //--------------------------CONSTRUCTORS----------------------------------------------------------------------------
        public clsStudent()
        {
            vName = "Undefined";
            vBirthday = new clsDate();
            vGrade = -1;
            
        }
        public clsStudent(string aNumber,string aName, int aDay , int aMonth, int aYear, Single aGrade  )
        {
            Birthday = new clsDate(aDay,aMonth,aYear);
            Name = aName;
            vGrade = aGrade;
            Number = aNumber;
            
            
        }
        public clsStudent(string aName, clsDate aDate, Single aGrade)
        {
            Birthday =aDate;
            Name = aName;
            vGrade = aGrade;
        }
        //--------------------------PROPERTIES---------------------------------------------------
        public string Name
    {
        get
            {
                return vName;
            }
            set // for writing the value of the feild associated to the property
            {
                vName = value;
            }
        }
        public string Number
        {
            get
            {
                return vNumber;
            }
            set // for writing the value of the feild associated to the property
            {
                vNumber = value;
            }
        }

        public Single Grade
        {
            get // for reading the value of the feild associated to the property
            {
                return vGrade;
            }
            //set // for writing the value of the feild associated to the property    // no set because the property is read-only
            //{                                                                        
            //    vGrade = (value >= 0 && value <= 100) ? value : -1;
            //}
        }

        public int Age
        {
            get
            {
                return Birthday.Year - DateTime.Today.Year;
            }


        }
        public clsDate Birthday
        {
            get
            {
                return vBirthday;
            }
            
            set
            {
                vBirthday = value;
            }
        }
        
        //--------------------------------------METHODS------------------------------------------------------------------------
        public void Register(string aName, int aDay, int aMonth, int aYear)
        {
            Name = aName;
            Birthday = new clsDate(aDay, aMonth, aYear);
            vGrade = -1;
        }
        public bool toGrade( Single aGrade)
        {
            if (aGrade > 0 && aGrade < 100)
            {
                vGrade = aGrade;
                return true;
            }
            else
            {
                return false;

            }
          
        }
       
        public string Display()
        {
            
            string info;
            info = "Name : " + Name + "\n Birthday :" + Birthday.toLetter()  + "\nGrade : " + Grade +"/ 100" + "\nAge :" + Age + " years";
            return info;

        }

    }

}
