using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMAD.ClassLibs
{
    public class MailCarrier
    {
        //private DateTime dob;
        private string emailAlias;
        private string name;

        public DateTime DOB { get; } = new DateTime(1980, 1, 2);

        public string EmailAddress 
        { 
            get 
            {
                if (string.IsNullOrEmpty(emailAlias))
                {
                    throw new DataException("Email alias required");
                }
                return emailAlias + "@gnb.ca";
            } 
        }

        public string Name 
        { 
            get
            {
                if (string.IsNullOrEmpty(emailAlias))
                {
                    throw new DataException("");
                }

                if (emailAlias.Contains("."))
                {
                    string[] parts = emailAlias.Split('.');
                    return $"{parts[0]} {parts[1]}";
                }

                return emailAlias;
            }
        }

        public string EmailAlias { set { emailAlias = value; } }
    }
}
