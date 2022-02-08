using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Usageofdelegates
    {
        static void main()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee() { empid = 101, empname = "Devika", experience = 12, salary = 120000 });
            emplist.Add(new Employee() { empid = 102, empname = "palak", experience = 15, salary = 120000 });
            emplist.Add(new Employee() { empid = 103, empname = "sai", experience = 3, salary = 120000 });
            emplist.Add(new Employee() { empid = 104, empname = "ab", experience = 4, salary = 120000 });

            IsPromotable ispt = new IsPromotable(Promote);
            Employee.promoteEmployee(emplist, ispt);
            Console.Read();
        }
        public static bool Promote(Employee emp)
        {
            if(emp.experience>10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
   public delegate bool IsPromotable(Employee e);
   public class Employee
    {
        public int empid { get; set; }
        public string empname { get; set; }
        public int salary { get; set; }
        public int experience { get; set; }

        public static void promoteEmployee(List<Employee> emplist,IsPromotable isp)
        {
            foreach(Employee emp in emplist)
            {
                if (isp(emp))
                {
                    Console.WriteLine(emp.empname + "Promoted");
                }

            }

        }
    }
}
