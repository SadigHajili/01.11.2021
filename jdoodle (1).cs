using System;

class Program
{
    static void Main(string[] args) 
    {
      
      Car theBMW = new Car();
      theBMW.brand = "BMW";
      theBMW.doorCount = 4;
      theBMW.model = "E39";
      theBMW.color = "black";
      theBMW.fuelcapacity = 75;
      
      theBMW.model_and_brand();
      theBMW.full_fuel(10);
      
      

    }

    class Car
    {


        public string brand;      
        public string color;
        public int fuelcapacity;
        public int doorCount;
        public string model;
        
        
        
        
        public void model_and_brand()
        {
            Console.WriteLine("Model: "+model+"\nBrand: "+brand);
        }
        
        public void full_fuel(int consumption)
        {
            Console.WriteLine("Masin Polnu Bakla "+(fuelcapacity*consumption)+" km gedecek");
        }
       
    }
}