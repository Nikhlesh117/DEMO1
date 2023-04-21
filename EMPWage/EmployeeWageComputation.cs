using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPWage
{
    public class EmployeeWageComputation
    {
        public void CheckEmployee()
        {
            int FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(2);

            if (empCheck == FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
