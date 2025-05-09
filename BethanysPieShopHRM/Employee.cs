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
        
        const int minimalHoursWorkedUnit = 1;
        
        public Employee(string first, string last, string em, DateTime bd) : this(first, last, em, bd, 0)
        {
        }

        public Employee(string first, string last, string em, DateTime bd, double rate)
        {
            firstName = first;
            lastName = last;
            email = em;
            birthDay = bd;
            hourlyRate = rate;
        }
        
        public void PerformWork()
        {
            numberOfHoursWorked++;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
        }

        public void PerformWork(int numberOfHours)
        {
            numberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
        }

        public int CalculateBonus(int bonus)
        {
            if (numberOfHoursWorked > 10)
                bonus *= 2;
            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;
        }

        public int CalculateBonusAndBonusTax(int bonus, ref int bonusTax)
        {
            if (numberOfHoursWorked > 10)
                bonus *= 2;
            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee ogt a bonus of {bonus} and the tax on the bonus is {bonusTax}");
            return bonus;
        }
        
        public double ReceiveWage(bool resetHours = true)
        {
            wage = numberOfHoursWorked * hourlyRate;
            
            Console.WriteLine($"{firstName} {lastName} has received a wage of {wage:C} for {numberOfHoursWorked} hour(s) of work!");
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
