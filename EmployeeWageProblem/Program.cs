using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CheckAttendance checkAttendance = new CheckAttendance();
            checkAttendance.CheckEmployee();
            Console.ReadLine(); 
        }
    }
}
