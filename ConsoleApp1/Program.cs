using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ahmed Ismail
            //Console.WriteLine(SayHello());
            //Console.WriteLine(SayHello("Ahmed Ismaeil"));

            //string myname = SayHello();
            //Console.WriteLine(SayHello());
            //string mstring = SayHello("Marwan");
            //Console.WriteLine(mstring);

            //string fullName = SayHello("Marwan", "Alshemy");
            //Console.WriteLine(fullName);
            //Console.WriteLine(SayHello("Ahmed", "Ismaeil"));

            //Employee employee = new Employee();
            //employee.ID = 1;
            //employee.FullName = "Mahmoud";

            //GetDetails(employee);
            //Console.WriteLine(GetDetails(employee)); //ConsoleApp1.Employee

            //Console.WriteLine(SayHello(employee)); //Mahmoud



            Employee emp = new Employee();
            emp.ID = 1;
            emp.FullName = "Mahmoud";
            emp.Dept = "IT";
            Console.WriteLine(EmpDetails(emp)); //1 Mahmoud IT
        }
        static string SayHello()
        {
            string name = "Ahmed";
            return name;
        }
        static string SayHello(string name)
        {
            string fullname = name + " Family Name";
            return fullname;
        }

        static string SayHello(string fName, string lName)
        {
            string fullname = fName + " " + lName;
            return fullname;
        }
        static string SayHello(Employee emp)
        {
            return emp.FullName;
        }

        static Employee GetDetails(Employee emp)
        {
            return emp;
        }

        static string EmpDetails(Employee obj)
        {
            return obj.ID + " " + obj.FullName+" " + obj.Dept;
        }
      

    }

    class Employee
    {
        public int ID
        {
            get; set;
        }
        public string FullName
        {
            get; set;
        }
        public string Dept
        {
            get; set;
        }
    }
}
