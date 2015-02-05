using System;

class Battery
{
    private string batt;
    private int battLife;

    public Battery(string batt, int battLife)
    {
        this.Batt = batt;
        this.BattLife = battLife;
    }

    public string Batt
    {
        get
        {
           return this.batt;   
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("The battery name cannot empty!"); 
            }
            this.batt = value;
            ;
        }
    }

    public int BattLife 
    {
        get
        {
            return this.battLife;
        }

        set
        {
            if (value<0)
            {
                throw new ArgumentException("The Battery life cannot be negative value!");
            }
            this.battLife = value;
            ;
        } 
    }

    public override string ToString()
    {
        return string.Format("Battery: {0} \nBattery Life: {1}", this.batt, this.battLife);
    }
}

