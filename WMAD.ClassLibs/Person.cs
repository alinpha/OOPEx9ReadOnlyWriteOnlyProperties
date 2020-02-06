using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMAD.ClassLibs
{
    public class Person
    {
        private string company = "NBCC Moncton";
        private DateTime dateOfBirth;
        private bool aidOff;

        /// <summary>
        /// write only prop
        /// </summary>
        public DateTime DateOfBirth
        {
            set
            {
                dateOfBirth = value;
            }
        }

        /// <summary>
        /// auto prop no unit test required.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// read only prop.
        /// </summary>
        public string Company
        {
            get
            {
                return company;
            }
        }

        /// <summary>
        /// write only
        /// </summary>
        public bool LaidOff
        {
            set
            {
                LaidOff = value;
            }
        }

        public int Age
        {
            get
            {
                DateTime now = DateTime.Now;
                int age = now.Year - dateOfBirth.Year;
                if (now.Month < dateOfBirth.Month) {
                    age--;
                } else if (now.Month == dateOfBirth.Month)
                {
                    if (now.Day < dateOfBirth.Day) {
                        age--;
                    }
                }

                return age;
            }
        }

    }
}
