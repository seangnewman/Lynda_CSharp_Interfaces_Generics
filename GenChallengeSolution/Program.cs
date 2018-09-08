using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenChallengeSolution
{
    public class ClassicCar
    {
        public string m_Make;
        public string m_Model;
        public int m_Year;
        public int m_Value;

        public ClassicCar(string make, string model, int year, int val) {
            m_Make = make;
            m_Model = model;
            m_Year = year;
            m_Value = val;
        }
    }

    class Program
    {
        static void Main(string[] args) {
            List<ClassicCar> carList = new List<ClassicCar>();
            populateData(carList);

            // How many cars are in the collection?
            Console.WriteLine("There are {0} cars in the collection", carList.Count);

            // How many Fords are there?
            int countFords = 0;
            foreach (ClassicCar car in carList)
            {
                 if(car.m_Make == "Ford")
                {
                    countFords++;
                }
            }
            Console.WriteLine("There are {0} Fords in the collection", countFords);

            // What is the most valuable car?
            double maxValue = 0;
            foreach (ClassicCar car in carList)
            {
                if (car.m_Value > maxValue) {
                    maxValue = car.m_Value;
                } 
            }
            Console.WriteLine("The maximum car value is {0}", maxValue);

            // What is the entire collection worth?
            double total = 0;
            foreach (ClassicCar car in carList)
            {
                total += car.m_Value;
            }
            Console.WriteLine("The total value of the collection is  {0}" , total);

            // How many unique manufacturers are there?
            List<string> manufacturers = new List<string>();
            foreach (ClassicCar car in carList)
            {
                if (!manufacturers.Contains(car.m_Make))
                {
                    manufacturers.Add(car.m_Make);
                }
                
            }
            Console.Write("The list of manufacturers are ");
            foreach (string manufacturer in manufacturers)
            {
                Console.Write(" {0} ", manufacturer);
            }
            Console.WriteLine();
            Console.WriteLine("\nHit Enter key to continue...");
            Console.ReadLine();
        }

        static void populateData(List<ClassicCar> theList) {
            theList.Add(new ClassicCar("Alfa Romeo", "Spider Veloce", 1965, 15000));
            theList.Add(new ClassicCar("Alfa Romeo", "1750 Berlina", 1970, 20000));
            theList.Add(new ClassicCar("Alfa Romeo", "Giuletta", 1978, 45000));

            theList.Add(new ClassicCar("Ford", "Thunderbird", 1971, 35000));
            theList.Add(new ClassicCar("Ford", "Mustang", 1976, 29800));
            theList.Add(new ClassicCar("Ford", "Corsair", 1970, 17900));
            theList.Add(new ClassicCar("Ford", "LTD", 1969, 12000));

            theList.Add(new ClassicCar("Chevrolet", "Camaro", 1979, 7000));
            theList.Add(new ClassicCar("Chevrolet", "Corvette Stringray", 1966, 21000));
            theList.Add(new ClassicCar("Chevrolet", "Monte Carlo", 1984, 10000));

            theList.Add(new ClassicCar("Mercedes", "300SL Roadster", 1957, 19800));
            theList.Add(new ClassicCar("Mercedes", "SSKL", 1930, 14300));
            theList.Add(new ClassicCar("Mercedes", "130H", 1936, 18400));
            theList.Add(new ClassicCar("Mercedes", "250SL", 1968, 13200));
        }
    }
}
