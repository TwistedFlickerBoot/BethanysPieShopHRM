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
            
            // Additional logic for employeeRick can be added here
        }
    }
}