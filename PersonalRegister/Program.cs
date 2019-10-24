using System;

namespace PersonalRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Payroll payroll = new Payroll();

            payroll.Add("John Smith", 30000);
            payroll.Add("Susana Smith", 35000);
            payroll.Add("Rebecca Smith", 38500);

            Console.WriteLine("Enter a new employee and salary, Quit with Q");

            do
            {
                string name = Util.AskForString("Name: ");
                if (name == "Q") break;
                int salary = Util.AskForInt("Salary: ");

                payroll.Add(name, salary);
            }
            while (true);


            foreach (var item in payroll.GetEmployees())
            {
                Console.WriteLine(item);

                switch (item.SalaryLevel)
                {
                    case SalaryLevel.Junior:
                        Console.WriteLine("Do Junior Work");
                        break;
                    case SalaryLevel.Senior:
                        Console.WriteLine("Do Senior Work");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("---------------------------");
            }

        }
    }

}
