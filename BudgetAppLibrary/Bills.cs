using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetAppLibrary

{
    public class Bills
    {

        public int amountOfBills { get; set; }
        

        public int GenerateBills() 
        {

            int x;

            Console.WriteLine("How many bills do you have?\n");

            amountOfBills = Convert.ToInt32(Console.ReadLine());

            int[] arrayOfBills = new int[amountOfBills];
            string[] nameOfBills = new string[amountOfBills];
            double[] priceOfBills = new double[amountOfBills];

            foreach (int i in arrayOfBills) { x = 0; nameOfBills[i] = Console.ReadLine(); x++; }
            foreach (string str in nameOfBills) { Console.WriteLine($"{str}\n"); }
            foreach (int i in arrayOfBills) { x = 0;  priceOfBills[i] = Convert.ToDouble(Console.ReadLine()); x++; }
            foreach (double dbl in priceOfBills) { Console.WriteLine($"{dbl}\n");  }

            return amountOfBills;
        }
    }
}
