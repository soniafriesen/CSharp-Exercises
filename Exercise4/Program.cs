using System;
using System.Collections;
using System.Collections.Generic;

namespace Exercise4_SF
{
    class Program
    {
        static void Main(string[] args)
        {
            //employees
            Employee Ann = new Employee(1, "Ann",1000,100.0);
            Employee John = new Employee(2, "John", 45000.0, 1500.0);
            Employee Mike = new Employee(3, "Mike", 35000.0, 1200.0);

            //list of employees
            List<Employee> employees = new List<Employee>();
            employees.Add(Ann);
            employees.Add(John);
            employees.Add(Mike);
            Console.WriteLine("Please enter Salary for each employee: ");

            //get the user to input the salary;
            foreach (Employee e in employees)
            {
                Console.WriteLine("Salary for " + e.Name);
                bool isNumber = false;
                double num = 0.0;
                while (!isNumber)
                {
                    Console.Write("-> ");
                    string salary = Console.ReadLine();
                    try
                    {
                        isNumber = Double.TryParse(salary, out num);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception caught " + ex.Message);
                    }
                }
                e.Salary = num;
            }
            Console.WriteLine("Using the CalculateTax() to get values for UpdatePayRoll() in Employee class.");
            Console.WriteLine();
            //using the iterator and calcuate the tax for each employee
            int counter = 0; //counter to get the corresponding employee numbers
            foreach (double[] arr in CalculateTax(employees))
            {
                employees[counter].UpdatePayRoll(arr[1], arr[0], (int)arr[2]);
                counter++;
            }
            Console.WriteLine("\nPrinting out the results from CalculateTax and UpdatePayRoll()");
            foreach (Employee e in employees)
            {
                Console.WriteLine(e.ToString()); //using the ToString method to print out employee
            }
            Console.WriteLine();

            //create one lists for FindAll and Sort and Foreach methods
            Console.WriteLine("lists for FindAll and Sort and Foreach methods\n");
            Employee Lisa = new Employee(1, "Lisa", 19500.0, 1500.0);
            Employee Michelle = new Employee(2, "Michelle", 7500.0, 2500.0);
            Employee Addison = new Employee(3, "Addison", 50000.0, 2000.0);
            List<Employee> list1 = new List<Employee>();
            list1.Add(Lisa);
            list1.Add(Michelle);
            list1.Add(Addison);            
            counter = 0;  //same as above
            foreach (double[] arr in CalculateTax(list1)) //get the tax values for each employee
            {
                list1[counter].UpdatePayRoll(arr[1], arr[0], (int)arr[2]);
                counter++;
            }
            Action<Employee> print = e => Console.WriteLine(e.ToString()); //use action to print
            Console.WriteLine("Employees in list1 (not sorted)");
            foreach (var e in list1)
            {
                print.Invoke(e); //invoke
            }
            Console.WriteLine();           
            Console.WriteLine("Printing all employees whos net income is greater than 10,000");
            list1.FindAll(e => e.NetIncome > 10000.0).ForEach(print);

            //sorting list by tax value
            Console.WriteLine();
            Console.WriteLine("Printing all employees sorted by tax value");
            list1.Sort((e1, e2) => e1.Tax.CompareTo(e2.Tax));
            list1.ForEach(print);
        }
        public static IEnumerable CalculateTax(List<Employee> employees)
        {
            try
            {
               double[] taxes = new double[3];
               foreach(Employee e in employees)
                {                   
                    //calculate taxes using formula from exercise 4 sheet
                    double grossincome = e.Bonus + e.Salary;
                    double benefit = 0.01 * grossincome;
                    double EI = 0.05 * grossincome;
                    double CPP = 0.05 * grossincome;
                    double tax = 0.0;
                    if (grossincome <= 50000.0)
                        tax = 0.20 * grossincome;
                    else
                        tax = 0.30 * grossincome;
                    double deductions = benefit + EI + CPP + tax;
                    double netIncome = grossincome - deductions;
                    taxes[0] = netIncome;
                    taxes[1] = tax;
                    taxes[2] = (double)DateTime.Now.Year-1;
                    yield return taxes;
                }
            }finally
            {
                //disposing resources in finally block                
                Console.WriteLine("Disposing resources\n");
            }
        }
    }
}
