// See https://aka.ms/new-console-template for more information
using BudgetAppLibrary;

internal class Engine
{
    private static void Main(string[] args)
    {
        BudgetCalculator budgeCalc = new BudgetCalculator();
        SavingGoals goals = new SavingGoals();
        Bills bills = new Bills();
        double amountDesired;

        while (true) 
        {
            bills.GenerateBills();
            budgeCalc.GetNumbers();
            budgeCalc.GetOverTime();
            Console.WriteLine("\nHow much would you like to save toward?");
            amountDesired = Convert.ToDouble(Console.ReadLine());
            goals.OneMonthSavingPlan(amountDesired);
            Console.ReadLine();
        }
    }
}