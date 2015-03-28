using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace _02.Customer
{
    class Customer
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private int egn;
        private string address;
        private int phone;
        private string eMail;
        private List<Payment> payments;
        private CustomerType cusType;

        public Customer(string firstName, string middleName, string lastName, int egn, string address, int phone, string eMail, List<Payment> payments, CustomerType cusType)
        {
            firstName = firstName;
            middleName = middleName;
            lastName = lastName;
            egn = egn;
            address = address;
            phone = phone;
            eMail = eMail;
            payments = payments;
            cusType = cusType;
        }  
    }
}
