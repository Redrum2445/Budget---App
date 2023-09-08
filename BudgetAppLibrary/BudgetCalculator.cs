// See https://aka.ms/new-console-template for more information
using BudgetAppLibrary;

public class BudgetCalculator
{
    public const double wage = 17.75;
    public const double shiftDif = 2.00;
    public const double fullWage = wage + shiftDif;
    public const double insuranceDeduction = 27.63;
    public double hoursPerWeek;
    public double totalPreTax;
    public double taxCut = .19067;
    public double weeklyWage;
    public void GetNumbers()
    {
        Console.WriteLine($"Hourly wage: ${wage}\nShift differential: ${shiftDif}/Hr.\n\nHow many hours did you work this week?");
        hoursPerWeek = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"You worked {hoursPerWeek} hours this week.\nEach check ${insuranceDeduction} is taken out for insurance.");
    }
    public double GetOverTime()
    {
        if (hoursPerWeek>= 40)
        {
            double overTimeWorked = hoursPerWeek - 40;
            double timeAndAHalf = fullWage * 1.5;
            totalPreTax = hoursPerWeek * fullWage + timeAndAHalf * overTimeWorked;
            double amountDue = totalPreTax * taxCut;
            double totalPostTax = totalPreTax - amountDue;
            double weeklyWage = Math.Floor(totalPostTax - insuranceDeduction);
            Console.WriteLine($"Total before tax: ${totalPreTax}\nAmount due from tax: ${amountDue}\nTotal After tax: ${totalPostTax}\nYou worked overtime this week, so you'll make ${timeAndAHalf}/Hr.\nThis will net a total ${weeklyWage} this week.");
            return weeklyWage;
        }
        else
        {
            totalPreTax = (wage + shiftDif) * hoursPerWeek;
            Console.WriteLine($"Total before tax: {totalPreTax}");
            double amountDue = totalPreTax * taxCut;
            Console.WriteLine($"Amount due from tax: {amountDue}");
            double totalPostTax = totalPreTax - amountDue;
            Console.WriteLine($"Total After tax: {totalPostTax}");
            weeklyWage = Math.Floor(totalPostTax - insuranceDeduction);
            Console.WriteLine($"No overtime, so you'll make ${weeklyWage} this week.");
            return weeklyWage;
        }
    }
}