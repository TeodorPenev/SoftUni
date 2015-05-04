using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class Companies:ICompany
    {
        protected string name;
        protected string registrationNumber;

        public Companies(string name,string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length<5)
                {
                    throw new ArgumentNullException("Invalid command name: {0}",value);
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get { return this.RegistrationNumber; }

            set
            {
                if (value.Length!=10 || Isletter(string value))
                {
                    
                }
                
            }
        }

        private bool Isletter(object o)
        {
            
        }

        public ICollection<IFurniture> Furnitures
        {
            get { throw new NotImplementedException(); }
        }

        public void Add(IFurniture furniture)
        {
            throw new NotImplementedException();
        }

        public void Remove(IFurniture furniture)
        {
            throw new NotImplementedException();
        }

        public IFurniture Find(string model)
        {
            throw new NotImplementedException();
        }

        public string Catalog()
        {
            throw new NotImplementedException();
        }
    }
}
