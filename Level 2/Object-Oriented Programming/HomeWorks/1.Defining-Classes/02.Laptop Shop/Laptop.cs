using System;

class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private int ram;
    private string graphicsCard;
    private string hdd;
    private string screen;
    private decimal price;
    private Battery batt;

    public Laptop(string model,decimal price)
    {
        this.Model = model;
        this.Price = price;
    }

    public Laptop(string model, decimal price,Battery battery, string manufacturer = null, string processor = null, int ram = 0, string graphicsCard = null, string hdd = null, string screen = null) : this(model,price)
    {
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicsCard = graphicsCard;
        this.HDD = hdd;
        this.Screen = screen;
        this.batt = battery;
    }

    public string Model
    {
        get { return this.model; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The Model name cannot be empty!");
            }
            this.model = value;
        }
    }

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The Manufacturer name cannot be empty!");
            }
            this.manufacturer = value;
            ;
        }
    }

    public string Processor
    {
        get
        {
            return this.processor;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The Processor name cannot be empty!");
            }
            this.processor = value;
            ;
        }
    }

    public int Ram
    {
        get
        {
            return this.ram; 
            
        }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("The Ram cannot be negative!");
            this.ram = value;
        }
    }

    public string GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The GraphicsCard name cannot be empty!");
            }
            this.graphicsCard = value;
            ;
        }
    }

    public string HDD
    {
        get
        {
            return this.hdd;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The HDD name cannot be empty!");
            }
            this.hdd = value;
            ;
        }
    }

    public string Screen
    {
        get
        {
            return this.screen;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The Screen name cannot be empty!");
            }
            this.screen = value;
            ;
        }
    }

    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("The price cannot be negative!");
            }
            this.price = value;
            ;
        }
    }
    public override string ToString()
    {
        return string.Format("Model: {0} \nManufacturer: {1} \nProcessor: {2} \nRAM: {3} GB\nGraphicsCard: {4} \nHDD: {5} \nScreen: {6} \n{7} \nPrice {8} lv.", this.model, this.manufacturer, this.processor, this.ram, this.graphicsCard, this.hdd, this.screen, this.batt, this.price);
    }
}

