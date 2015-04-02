using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading;

namespace _02.Customer
{
    class Customer:ICloneable,IComparable<Customer>
    {
        public Customer(string firstName, string middleName, string lastName, long egn, string address, int phone, string eMail, List<Payment> payments, CustomerType cusType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Egn = egn;
            this.Address = address;
            this.Phone = phone;
            this.EMail = eMail;
            this.Payments = payments;
            this.CusType = cusType;
        }

        public CustomerType CusType { get; set; }

        public List<Payment> Payments { get; set; }

        public string EMail { get; set; }

        public int Phone { get; set; }

        public string Address { get; set; }

        public long Egn { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string FirstName { get; set; }

        public override bool Equals(object obj)
        {
            Customer objC = obj as Customer;
            if (objC == null)
            {
                return false;
            }

            if (objC.Egn != this.Egn)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator ==(Customer customer1, Customer customer2)
        {
            return Equals(customer1, customer2);
        }

        public static bool operator !=(Customer customer1, Customer customer2)
        {
            return !Equals(customer1, customer2);
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ Egn.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("First name: {0}, Middle name: {1}, Last name: {2}, EGN: {3}, Address: {4}, Phone: {5}, Email: {6}, Payments({7}), CustomerType: {8}", this.FirstName,this.MiddleName,this.LastName,this.Egn,this.Address,this.Phone,this.EMail,String.Join(",",this.Payments),this.CusType));
            return result.ToString();
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public Customer Clone()
        {
            Customer result = new Customer(this.FirstName,this.MiddleName,this.LastName,this.Egn,this.Address,this.Phone,this.EMail,this.Payments,this.CusType);
            return result;
        }

        public int CompareTo(Customer other)
        {
            string otherFullName = other.FirstName + " " + other.MiddleName + " " + other.LastName;
            string thisFullName = this.FirstName + " " + this.MiddleName + " " + this.LastName;

            if (otherFullName != thisFullName)
            {
                int result = string.Compare(otherFullName, thisFullName);
                return -result;
            }
            else
            {
                if (other.Egn!=this.Egn)
                {
                    long result = other.Egn - this.Egn;
                    return -(int)result;
                }
            }
            return 0;
        }
    }
}
