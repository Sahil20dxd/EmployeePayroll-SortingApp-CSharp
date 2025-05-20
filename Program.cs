using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    /// <summary>
    /// Program is the view class containg method that performs operations like reading and sorting data
    /// </summary>
    internal class Program

    // I, Sahil Hirpara, 000123456 certify that this material is my original work.No other person's work has been used without due acknowledgement.

    {
        /// <summary>
        /// DATAFILE stores the data from.csv file and array is created of name employee
        /// </summary>
        const string DATAFILE = "employees.txt";
        static Employee[] employees = new Employee[100];

        /// <summary>
        /// It is a read method that reads data from DATAFILE and formats them and stores them in array employees for further use
        /// </summary>
        static void read()
        {
            try
            {
                StreamReader reader = new StreamReader(DATAFILE);
                int index = 0;
                while (!reader.EndOfStream && index < employees.Length)
                {
                    string[] items = reader.ReadLine().Split(',');


                    employees[index++] = new Employee(items[0].Trim(), int.Parse(items[1].Trim()), decimal.Parse(items[2].Trim()), double.Parse(items[3].Trim()));

                }

                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// it is a sorting method performing insertion sort of data in employee and with help of switch case it give choices to user to select from which attribute they want their data to be fromatted and in the end it is displayed to user.
        /// </summary>
        /// <param name="employees"></param>
        public static void sort(Employee[] employees)
        {

            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.Write("m e n u\n=======\n" +
                                    "[1] - sort by employee name (ascending)\n" +
                                    "[2] - sort by employee number (ascending)\n" +
                                    "[3] - sort by employee pay rate (descending)\n" +
                                    "[4] - sort by employee hours (descending)\n" +
                                    "[5] - sort by employee gross pay (descending)\n" +
                                    "[6] - exit program\n\n" +
                                    "option : ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        for (int i = 1; i < employees.Length; i++)
                        {
                            if (employees[i] == null) continue;

                            var key = employees[i];
                            int j = i - 1;


                            while (j >= 0 && employees[j] != null && string.Compare(employees[j].GetName(), key.GetName()) > 0)
                            {
                                employees[j + 1] = employees[j];
                                j = j - 1;
                            }
                            employees[j + 1] = key;
                        }

                        Console.WriteLine("Sorted by Employee Name (Ascending):");
                        foreach (var employee in employees)
                        {
                            if (employee != null)
                                Console.WriteLine(employee.toString());
                        }
                        break;


                    case "2":
                        for (int i = 1; i < employees.Length; i++)
                        {
                            if (employees[i] == null) continue;

                            var key = employees[i];
                            int j = i - 1;


                            while (j >= 0 && employees[j] != null && (employees[j].GetNumber() > key.GetNumber()))
                            {
                                employees[j + 1] = employees[j];
                                j = j - 1;
                            }
                            employees[j + 1] = key;
                        }

                        Console.WriteLine("Sorted by Employee Number (Ascending):");
                        foreach (var employee in employees)
                        {
                            if (employee != null)
                                Console.WriteLine(employee.toString());
                        }
                        break;

                    case "3":
                        for (int i = 1; i < employees.Length; i++)
                        {
                            if (employees[i] == null) continue;

                            var key = employees[i];
                            int j = i - 1;


                            while (j >= 0 && employees[j] != null && (employees[j].GetRate() < key.GetRate()))
                            {
                                employees[j + 1] = employees[j];
                                j = j - 1;
                            }
                            employees[j + 1] = key;
                        }

                        Console.WriteLine("Sorted by Employee Pay Rate (Descending):");
                        foreach (var employee in employees)
                        {
                            if (employee != null)
                                Console.WriteLine(employee.toString());
                        }

                        break;

                    case "4":
                        for (int i = 1; i < employees.Length; i++)
                        {
                            if (employees[i] == null) continue;

                            var key = employees[i];
                            int j = i - 1;


                            while (j >= 0 && employees[j] != null && (employees[j].GetHours() < key.GetHours()))
                            {
                                employees[j + 1] = employees[j];
                                j = j - 1;
                            }
                            employees[j + 1] = key;
                        }

                        Console.WriteLine("Sorted by Employee Hours (Descending):");
                        foreach (var employee in employees)
                        {
                            if (employee != null)
                                Console.WriteLine(employee.toString());
                        }
                        break;

                    case "5":
                        for (int i = 1; i < employees.Length; i++)
                        {
                            if (employees[i] == null) continue;

                            var key = employees[i];
                            int j = i - 1;


                            while (j >= 0 && employees[j] != null && (employees[j].GetGross() < key.GetGross()))
                            {
                                employees[j + 1] = employees[j];
                                j = j - 1;
                            }
                            employees[j + 1] = key;
                        }

                        Console.WriteLine("Sorted by Employee Gross rate (Descending):");
                        foreach (var employee in employees)
                        {
                            if (employee != null)
                                Console.WriteLine(employee.toString());
                        }
                        break;

                    case "6":
                        flag = false;
                        break;


                    default:
                        Console.Error.WriteLine("invalid option");
                        Console.Beep(); ;
                        break;
                }
                Console.Write("\n hit any key to continue ... ");
                Console.ReadKey();
            }
            Console.Write("\n bye");

        }

        /// <summary>
        /// It is the main method of the application which calls two method; read() and sort()
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            read();
            sort(employees);


        }
    }
}
