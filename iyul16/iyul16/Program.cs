using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iyul16
{
    class Program
    {
        static void Main(string[] args)
        {
            Car bmw = new Car("M5", "Bmw");
            string userInput;
            do
            {
                Console.WriteLine("1. Go");
                Console.WriteLine("2. Top up");
                Console.WriteLine("3. Local km");
                Console.WriteLine("4. Global km");
                Console.WriteLine("5. Exit");
                Console.WriteLine(">>>>>>>>>>>>");
                userInput = Console.ReadLine();
                if (CheckInput(userInput))
                {
                    switch (userInput)
                    {
                        case "1":
                            bmw.Go();
                            break;
                        case "2":
                            Console.WriteLine("Masina benzin vuruldu.");
                            bmw.Go();
                            break;
                        case "3":
                            Console.WriteLine("Local km");
                            bmw.Go();
                            break;
                        case "4":
                            Console.WriteLine("Global km");
                            bmw.Go();
                            break;
                        default:
                            Console.WriteLine("Xahis edirik yuxaridaki reqemlerin birini daxil edin !");
                            break;
                    }
                           
                
                }
            }
            while (userInput != "5");


            }
        public static bool CheckInput(string inp)
        {
            try
            {
                Convert.ToInt16(inp);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
        
         
}
        class Car
        {
            public string Marka;
            public string Model;
            private double CurrentFuel;
            private int Maxfuel;
            private int ConsumeFuel;
    public bool CheckInput(string inp)
    {
        try
        {
            Convert.ToInt16(inp);
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public Car(string Marka, string model, int currentfuell = 60, int maxfuell = 80, int consumeFuel = 14)
    {
        this.Marka = Marka;
        Model = model;
        CurrentFuel = currentfuell;
        Maxfuel = maxfuell;
        ConsumeFuel = consumeFuel;
    }   
         public void Go()
        {
        Console.WriteLine("Nece km getmek istiyirsiz ?");
        string input = Console.ReadLine();
        if(CheckInput(input))
        {
            double neededKm = 0;
            while (neededKm == 0) 
            {
                neededKm = Convert.ToDouble(input);

                if(CurrentFuel <= neededKm/100*ConsumeFuel)
                {
                    Console.WriteLine("Sizin kifayet benzininiz yoxdur. Zehmet olmasa benzin doldurun");
                }
                else
                {
                    CurrentFuel -= neededKm / 100 * ConsumeFuel;
                    Console.WriteLine("Sizin {0} km yol getdiniz. Hal-hazirda {1}lt benzininiz qaldi.", neededKm, CurrentFuel);
                }
            }
        }
        else
        {
            Console.WriteLine("Xahis edirik km-i musbet reqem daxil edin");
        }
        }
    }
