using System;

namespace BudgetCalculator
{
    class Program
    {
        static double YearlyConversion(double x) //Converting the month totals to year
        {
            x *= 12;
            return x;
        }

        private static string Subs(string x, string y) //Subscription function to print the same sentence
        {
            string sentence = $"Thank you, {x}!\nPlease enter your {y} subscription:"; 
            return sentence;
        }

        static string Bills(string y, string z) //Bill function to print the same sentence
        {
            string sentence = $"Thank you, {y}!\nPlease enter your {z} bill:";
            return sentence;
        }

        public static void Main(string[] args)
        {
            string _MonthlyIncomer, _OtherIncomer; //Income
            double _MonthlyIncome, _OtherIncome;
            string _WaterBillr, _GasBillr, _ElectricityBillr, _WeeklyFoodExpensesr; //essential expenses
            double _WaterBill, _GasBill, _ElectricityBill, _WeeklyFoodExpenses; //essential expenses
            string _DisneyPlusr, _Netflixr, _XboxGPr, _NowTVr, _OtherExpensesr; //luxury expenses
            double _DisneyPlus, _Netflix, _XboxGP, _NowTV, _OtherExpenses; //luxury expenses
            double _UtilityBill, _SubBill, _MonthlyFoodExpenses, _MonthlyExpenses; //all expenses converted into monthly outcome
            double _YearlyExpenses, Salary, _YearlyUtility, _YearlySubs, _YearlyFood, Savings; //yearly calculations

            Console.WriteLine("Please enter your name:");
            string _Username = Console.ReadLine(); //User's name

            Console.WriteLine($"Welcome {_Username}, to the budget calculator!");
            Console.WriteLine("This can be used to calculate salary, expenses and anything leftover."); //Quick explanation of app

            Console.WriteLine("Please enter your monthly income:");
            _MonthlyIncomer = Console.ReadLine(); //user will input their monthly income
            _MonthlyIncome = Convert.ToDouble(_MonthlyIncomer);

            Console.WriteLine(Bills(_Username, "water")); //WATER
            _WaterBillr = Console.ReadLine();
            _WaterBill = Convert.ToDouble(_WaterBillr);
            Math.Round(_WaterBill, 2);
            Console.WriteLine(Bills(_Username, "gas")); //GAS
            _GasBillr = Console.ReadLine();
            _GasBill = Convert.ToDouble(_GasBillr);
            Math.Round(_GasBill, 2);
            Console.WriteLine(Bills(_Username, "electricity")); //ELECTRICITY
            _ElectricityBillr = Console.ReadLine();
            _ElectricityBill = Convert.ToDouble (_ElectricityBillr);
            Math.Round(_ElectricityBill, 2);
            Console.WriteLine($"Thank you, {_Username}! \nPlease enter your approximate weekly food expenses:");
            _WeeklyFoodExpensesr = Console.ReadLine();        //FOOD EXPENSES input
            _WeeklyFoodExpenses = Convert.ToDouble (_WeeklyFoodExpensesr);
            Math.Round(_WeeklyFoodExpenses, 2);

            Console.WriteLine(Subs(_Username, "Disney+")); //DISNEY+
            _DisneyPlusr = Console.ReadLine();
            _DisneyPlus = Convert.ToDouble(_DisneyPlusr);
            Console.WriteLine(Subs(_Username, "Netflix")); //NETFLIX
            _Netflixr = Console.ReadLine();
            _Netflix = Convert.ToDouble(_Netflixr);
            Console.WriteLine(Subs(_Username, "Xbox gold pass")); //XBOX GOLD PASS
            _XboxGPr = Console.ReadLine();
            _XboxGP = Convert.ToDouble(_XboxGPr);
            Console.WriteLine(Subs(_Username, "Now TV")); //NOW TV
            _NowTVr = Console.ReadLine();
            _NowTV = Convert.ToDouble(_NowTVr);

            Console.WriteLine($"Thank you, {_Username}! \nPlease enter anything else that you have spent money on this month:");
            _OtherExpensesr = Console.ReadLine();        //ANYTHING ELSE expenses
            _OtherExpenses = Convert.ToDouble(_OtherExpensesr);

            Console.WriteLine($"Thank you, {_Username}! \nPlease enter anything else that you have earned money on this month:");
            _OtherIncomer = Console.ReadLine();        //ANYTHING ELSE income
            _OtherIncome = Convert.ToDouble(_OtherIncomer);
            
            Console.WriteLine("Calculating...");
           


            
            _UtilityBill = Convert.ToDouble(_WaterBill + _ElectricityBill + _GasBill); //Calculates utilities
            _SubBill = Convert.ToDouble(_Netflix + _DisneyPlus + _NowTV + _XboxGP); //Calculates subscriptions
            _MonthlyFoodExpenses = Convert.ToDouble (_WeeklyFoodExpenses) * 4; //Calculates food expenses
            Math.Round(_UtilityBill, 2); Math.Round(_SubBill, 2); Math.Round(_MonthlyFoodExpenses, 2); //Rounds everything to 2 decimal places

            _MonthlyExpenses = _UtilityBill + _SubBill + _MonthlyFoodExpenses; //Monthly expenses

            _YearlyExpenses = YearlyConversion(_MonthlyExpenses); //conversion to yearly expenses
            Salary = YearlyConversion(_YearlyExpenses); //monthly income converted to yearly salary
            _YearlyFood = YearlyConversion(_MonthlyFoodExpenses); //approx food expenses
            _YearlySubs = YearlyConversion(_SubBill); //subscription bill expenses
            _YearlyUtility = YearlyConversion(_UtilityBill); //utility bill expenses
            Savings = Salary - _YearlyExpenses; //overheads

            int i = 0;

            while (i == 0)
            {
                Console.WriteLine("What information do you want to display?\nexpenses, income, all?");
                string UserChoice = Console.ReadLine();

                if (UserChoice.Equals("expenses", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"Monthly:\nUtility Bill" + Math.Round(_UtilityBill, 2) + "\nSubscription Bill:" + Math.Round(_UtilityBill, 2) + "\nApproximate Food Expenses:" + Math.Round(_MonthlyFoodExpenses, 2));
                    Console.WriteLine($"Yearly:\nUtility Bill" + Math.Round(_YearlyUtility, 2) + "\nSubscription Bill: " + Math.Round(_YearlySubs, 2) + "\nApproximate Food Expenses: " + Math.Round(_YearlyFood, 2));
                    break;

                }
                else if (UserChoice.Equals("income", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"Monthly:\nIncome " + Math.Round(_MonthlyIncome, 2) + "\nOther Income: " + Math.Round(_OtherIncome, 2));
                    Console.WriteLine($"Yearly:\nIncome " + Math.Round(Salary, 2) + "\nTotal overheads:" + Math.Round (Savings, 2));
                    break;

                }
                else if (UserChoice.Equals("all", StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine($"Monthly Expenses\nUtility Bill : " + Math.Round(_UtilityBill, 2) + "\nSubscription Bill: " + Math.Round(_SubBill, 2) + "\nApproximate Food Expenses: " + Math.Round(_MonthlyFoodExpenses, 2));
                    Console.WriteLine($"Monthly Income\nIncome" + Math.Round(_MonthlyIncome, 2) + "\nOther Income: " + Math.Round(_OtherIncome, 2));
                    Console.WriteLine($"Yearly Expenses\nUtility Bill" + Math.Round(_YearlyUtility, 2) + "\nSubscription Bill:" + Math.Round(_YearlySubs, 2) + "\nApproximate Food Expenses: " + Math.Round(_YearlyFood, 2));
                    Console.WriteLine($"Yearly Income\nSalary" + Math.Round(Salary, 2) + "\nTotal overheads: " + Math.Round(Savings, 2));

                }
                else
                {
                    Console.WriteLine("Error, unknown command entered.");
                    continue;
                }
                Console.WriteLine("Do you want to see any other information?\nYes or no?");
                string YesNo = Console.ReadLine();
                if (YesNo.Equals("yes", StringComparison.InvariantCultureIgnoreCase))
                {
                    continue;
                }
                else if (YesNo.Equals("no", StringComparison.InvariantCultureIgnoreCase))
                {
                    i++;
                    break;
                } else
                {
                    continue;
                }

               


            }
        }
    }
}
