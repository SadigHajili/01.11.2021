using System;

class Program
{
    static void Main() {
      Bicycle Commuter = new Bicycle();
      Commuter.brand = "Stels";
      Commuter.model = "Commuter";
      Commuter.color = "Red";
      Commuter.wheelsize = 20;
      
      string cavab=Commuter.model_and_brand();
      Console.WriteLine(cavab);
    }
}
class Bicycle{
    
    public string brand;      
    public string color;
    public int wheelsize;
    public string model;
    
    public string model_and_brand(){
        string cavab = ("Model: "+model+"\nBrand: "+brand);
    
        return cavab;
    }
        
}