using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static program;

internal class program
{
    public class Emp
    {


        public void Salary(double wh, int nWdays, int projectHandless = 1, int extras = 0)
        {
            double salary = wh * nWdays * 100 + projectHandless * 3000 + extras * 2000;
            Console.WriteLine("Total Salary of Employee is: " + salary);
        }
    }

    static void Main(string[] args)
    {
        double wh;
        int nWdays;
        int projectHandles;
        int extras;
        Console.WriteLine("Choose Employee type by id : ");
        Console.WriteLine("1. hr for HR");
        Console.WriteLine("2. ad for Admin");
        Console.WriteLine("3. sd for Software Developer");


        string choice;
        Console.WriteLine("Enter the employee id : ");
        choice = Console.ReadLine();

        Emp emp = new Emp();
        switch (choice)

        {

            case "hr":
                {
                    Console.WriteLine("Enter Working Hour : ");
                    wh = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter No. of Working Days : ");
                    nWdays = int.Parse(Console.ReadLine());

                    emp.Salary(wh, nWdays);

                    break;

                }
            case "ad":
                {
                    Console.WriteLine("Enter Working Hour : ");
                    wh = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter No. of Working Days : ");
                    nWdays = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Project Handles :");
                    projectHandles = int.Parse(Console.ReadLine());

                    emp.Salary(wh, nWdays, projectHandles);
                    break;


                }
            case "sd":

                {
                    Console.WriteLine("Enter Working Hour : ");
                    wh = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter No. of Working Days : ");
                    nWdays = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Project handles");
                    projectHandles = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Extras : ");
                    extras = int.Parse(Console.ReadLine());

                    emp.Salary(wh, nWdays, projectHandles, extras);
                    break;

                }
            default:
                {

                    break;



                }
        }
        Console.ReadKey();

    }
}
