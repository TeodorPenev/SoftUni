using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures = new List<IFurniture>();


        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentNullException("Name cannot be empty, null or with less than 5 symbols.");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            set
            {
                if (value.Length != 10 || checkLetter(value))
                {
                    throw new ArgumentException("Registration number must be exactly 10 symbols and must contain only digits.");
                }
                this.registrationNumber = value;
            }
        }

        private bool checkLetter(string inputString)
        {
            foreach (var inputChar in inputString)
            {
                if (Char.IsLetter(inputChar))
                {
                    return true;
                }
            }
            return false;
        }

        public ICollection<IFurniture> Furnitures
        {
            get { return this.furnitures; }
        }

        public void Add(IFurniture furniture)
        {
            furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return furnitures.FirstOrDefault(furniture => furniture.Model == model);
        }

        public string Catalog()
        {
            StringBuilder compInfo = new StringBuilder();

            var catalog = furnitures.OrderBy(f => f.Price).ThenBy(f => f.Model);
          
               compInfo.Append(String.Format("{0} - {1} - {2} {3}",
                this.Name, this.RegistrationNumber,
                this.furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.furnitures.Count != 1 ? "furnitures" : "furniture"));
            foreach (var furniture in catalog)
            {
                compInfo.Append(string.Format("\n{0}", furniture.ToString()));
            }
            return compInfo.ToString();
        }
    }
}
