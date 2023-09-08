using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetAppLibrary
{
    public class SavingGoals
    {
        double amountToSave;

        int hoursInADay = 10;
        public double OneMonthSavingPlan(double amountToSave) 
        {
            int daysInAWeek = 5;
            int hoursInAWeek = hoursInADay * daysInAWeek;
            int hoursInAMonth = hoursInAWeek * 4;
            double hourOfWage = amountToSave / BudgetCalculator.fullWage;
            double weekOfWage = hourOfWage * hoursInAWeek;
            double monthOfWage = hourOfWage * hoursInAMonth;
            double lengthOfTime = amountToSave / hourOfWage;
            Console.WriteLine($"One hour of wage is worth ${hourOfWage}\nOne week of wage is worth ${weekOfWage}\nOne month of wage is worth ${monthOfWage}\n");

            //Console.WriteLine($"${amountDesired}");
            return amountToSave;
        }

    }
}
