namespace EMPWage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeWageComputation employee = new EmployeeWageComputation();
            employee.CheckEmployee("TaTa", 20, 20, 160);
            employee.CheckEmployee("Jindal", 10, 20, 120);
        }

    }
}