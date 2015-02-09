using System;

    class Person
    {
        private string name;
        private byte age;
        private string email;

        public Person(string name, byte age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, byte age)
            : this(name, age, null)
        {

        }
        
       
        public string Name
        {
            get
            {
                return this.name;
            }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }
                this.name = value;
                }
        }

        public byte Age 
        {
            get
            {
                return this.age;
            }
            set {
                if (value>100 || value<1)
                {
                    throw new ArgumentOutOfRangeException("Age got to be in range [1...100]!");
                }
                this.age = value;
                 } 
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set {
                if (value!="")
                {
                    if (value != null && !value.Contains("@"))
                    {
                        throw new ArgumentException("Invalid email!");
                    }
                }
               
                this.email = value;
            }
        }

        public override string ToString()
        {
            String result = String.Format("Name: {0}, Age: {1}", this.name, this.age);
            if (this.email != "")
            {
                result += String.Format(" Email: {0}", this.email);
            }
            return result;
        }
    }

