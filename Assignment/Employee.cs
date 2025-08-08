using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Employee
    {


        #region Properties

        public int ID { get; set; }
        public string? Name { get; set; }

        public SecurityLevel SecurityLevel { get; set; }


        public double Salary { get; set; }
        public Gender Gender { get; set; }
        public HiringDate? HiringDate { get; set; }



        #endregion




        #region Constructor

        public Employee(int iD, string? name, SecurityLevel securityLevel, double salary, Gender gender, HiringDate? hiringDate)
        {
            ID = iD;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            Gender = gender;
            HiringDate = hiringDate;
        }


        #endregion


        #region Method
        public override string ToString()
        {
            var culture = CultureInfo.GetCultureInfo("ar-EG");
            return string.Format("ID: {0}, Name: {1}, Gender: {2}, Security Level: {3}, Salary: {4}, Hiring Date: {5}",
                             ID, Name, Gender, SecurityLevel, Salary.ToString("C",culture), HiringDate);
        }

        #endregion


    }
}
