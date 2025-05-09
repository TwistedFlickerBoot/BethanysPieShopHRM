using System;

namespace BethanysPieShopHRM
{
    /// <summary>
    /// This class represents an employee.
    /// </summary>

    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;
        
        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;

        public DateTime birthDay;

        public void PerformWork()
        {
            numberOfHoursWorked++;
            console.writeLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
        }

        public void PerformWork(int numberOfHours)
        {
            numberOfHoursWorked += numberOfHours;
            console.writeLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
        }

        public double ReceiveWage(bool resetHours = true)
        {
            wage = numberOfHoursWorked * hourlyRate;
            
            console.writeLine($"{firstName} {lastName} has received a wage of {wage:C} for {numberOfHoursWorked} hour(s) of work!");
            if (resetHours)
                numberOfHoursWorked = 0;
            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine(
                $"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail: \t\t{email}\nBirthday: \t{birthDay.ToShortDateString()}");
        }
    }
}
