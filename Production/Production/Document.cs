using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Production
{
    //Object to hold letter-related information pulled from database
    public class Document
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }

        public int ChkAmt { get; set; }

        public int total { get; set; }

        public DateTime ChkDate { get; set; }

        public DateTime DueDate { get; set; }

        public string StoreName { get; set; }

        public string CompName { get; set; }

        public string CompStreet { get; set; }

        public string CompCity { get; set; }

        public string CompState { get; set; }

        public string CompZip { get; set; }

        public int CompFee { get; set; }

        public string CompPhoneNum { get; set; }


    }
}
