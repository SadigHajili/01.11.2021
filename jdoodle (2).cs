using System;

class Program
{
    static void Main() {
      Bicycle Commuter = new Bicycle("Stels", "Commuter", "Red", 20);
      Commuter.brand = "Stels";
      Commuter.model = "Commuter";
      Commuter.color = "Red";
      Commuter.wheelsize = 20;
      
      string cavab=Commuter.model_and_brand();
      Console.WriteLine(cavab);
    }
}

class Bicycle:Vehicle
{
    
    public string brand;      
    public string color;
    public int wheelsize;
    public string model;
    public Bicycle(string brand,string model,string color,int wheelsize):base(brand,model,color)
    {
        this.wheelsize = wheelsize;
        
    }
    public string model_and_brand()
    {
        string cavab = ("Model: "+model+"\nBrand: "+brand);
    
        return cavab;
    }
        
}

class Vehicle
{
    string brand;
    string model;
    string color;
    
    public Vehicle(string brand,string model,string color)
    {
        this.brand = brand;
        this.model = model;
        this.color = color;
    }
    
    public string brandAndModel()
    {
        string cavab = ("\nBrand: "+brand+"\nModel: "+model);
        return cavab;
    }
    
}
