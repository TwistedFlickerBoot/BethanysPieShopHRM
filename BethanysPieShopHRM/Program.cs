namespace BethanysPieShopHRM
{
    public class BethanysPieShopHRM
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Creating an employee");
            Console.WriteLine("--------------------");
            
            Employee employeeRick = new Employee("Rick", "Baker", "rick@rick.rick", new DateTime(1979, 1, 16), 25);
            employeeRick.DisplayEmployeeDetails();
            employeeRick.PerformWork();
            employeeRick.PerformWork();
            employeeRick.PerformWork(5);
            employeeRick.PerformWork();
            
            double receivedWageEmployeeRick = employeeRick.ReceiveWage();
            Console.WriteLine($"Wage paid  (message from Program): {receivedWageEmployeeRick}\n");

            Console.WriteLine("Creating an Employee");
            Console.WriteLine("--------------------");
            
            Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1980, 2, 28), 30);
            
            george.DisplayEmployeeDetails();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork(3);
            george.PerformWork();
            george.PerformWork(8);
            
            var receivedWageGeorge = george.ReceiveWage();

        }
    }
}