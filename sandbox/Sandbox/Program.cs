using System;

class Program
{
      static void Main(string[] args)
    {

      SalaryEmployee employee1 = new SalaryEmployee();
      employee1.SetName("Jorge");

      HourlyEmployee employee2 = new HourlyEmployee();
      employee2.SetName("Ever");

      DisplayInfo(employee1);
      DisplayInfo(employee2);

    }
    public static void DisplayInfo(Employee employee)
    {
      float pay = employee.CalculatePay();
      string name = employee.GetName();
      Console.WriteLine($"Name: {name} - Salary: {pay}"); 
    }
}
