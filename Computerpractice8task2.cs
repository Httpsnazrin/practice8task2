using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice8task2
{
    internal class Computer
    {
        public int Id { get; private set; }
        public string Model { get; private set; }
        public  string Brand { get; set; }
        private double price;

        public double Price
        {
            get { return price; }
            set 
            { 
            if (value <1000 || value> 12000)
                {
                    throw new ArgumentException("Error");
                }
                else
                {
                    price = value;
                }
            }
        }
        private string operatingSystem;

        public string OperatingSystem
        {
            get { return operatingSystem; }
            set
            {
                if (value.ToLower() == "windows" || value.ToLower() == "macos" || operatingSystem.ToLower()=="linux")
                {
                    operatingSystem = value;
                }
                else
                {
                    throw new ArgumentException("Operating system must be Windows, Linux, or MacOS.");
                }
            }
        }
        private string processorType;

        public string ProcessorType
        {
            get { return processorType; }
            set { if (value == "Intel" || value == "Ryzen")
                {
                    processorType = value;  
                }
                else
                {
                    throw new ArgumentException("Processor must be Intel or Ryzen.");
                }
            }
        }

        private int ram;

        public int Ram
        {
            get { return ram; }
            set {
            if (value<4 || value > 128)
                {
                    throw new ArgumentException("Error");
                }
                else
                {
                    ram = value;
                }
            }
        }
        public Computer(int id, string model, string brand, double price, string operatinSystem, string processorType, int ram)
        {
            Id = id;
            Model = model;
            Brand = brand;
            Price = price;
            OperatingSystem = operatinSystem;
            ProcessorType = processorType;
            Ram = ram;
        }
        public double CalcPriceWithTax()
        {
            double tax = 0.04;
            return Price * (1 + tax);

        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Model: {Model}, Brand: {Brand}, Operating System: {OperatingSystem}, Processor Type: {ProcessorType}, RAM: {Ram}GB");
        }

        public void GetUsefulOrNot()
        {
            if (Ram >= 4 && Ram <= 8)
            {
                Console.WriteLine("Ofis işləri üçündür");
            }
            else if (Ram > 8 && Ram <= 16)
            {
                Console.WriteLine("Proqramlaşdırma üçündür");
            }
            else if (Ram > 16 && Ram <= 32)
            {
                Console.WriteLine("Dizayn üçün");
            }
            else if (Ram > 32 && Ram <= 128)
            {
                Console.WriteLine("Oyun üçündür");
            }
            else
            {
                Console.WriteLine("Invalid RAM value");
            }
        }
    }
}
