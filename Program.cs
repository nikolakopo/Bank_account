using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class customer
    {

        public string firstname;
        public string lastname;
       
        public string IBAN;
        public customer(string firstname, string lastname,string iban)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.IBAN = iban;
           

        }

       
    }
}
