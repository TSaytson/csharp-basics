using System;
using System.Collections.Generic;
using System.Globalization;

namespace oop
{
  class Employee : Person
  {
    private Department department;
    public ushort Id { get; set; }

    private double Salary { get; set; }

    public DateTime StartDate;

    public void print()
    {
      CultureInfo.CurrentCulture = new CultureInfo("pt-BR");
      Console.WriteLine($"CurrentCulture is {CultureInfo.CurrentCulture.Name}");
      Console.Write("Salary: ");
      setSalary();
      Console.WriteLine($"{this.Name} has {this.Age} years old and earns {this.Salary:c} per month");
    }
    public void print(ushort Id)
    {
      this.Id = Id;
      CultureInfo.CurrentCulture = new CultureInfo("pt-BR");
      Console.WriteLine($"CurrentCulture is {CultureInfo.CurrentCulture.Name}");
      Console.Write("Salary: ");
      setSalary();
      Console.WriteLine($"{this.Name} with id {this.Id} has {this.Age} "
      + $"years old and earns {this.Salary:c} per month");
    }
    public void print(string culture)
    {
      CultureInfo.CurrentCulture = new CultureInfo(culture);
      Console.WriteLine($"CurrentCulture is {CultureInfo.CurrentCulture.Name}");
      Console.Write("Salary: ");
      setSalary();
      Console.WriteLine($"{this.Name} has {this.Age} years old and earns {this.Salary:c} per month");
    }
    public void setSalary(){
      try
      {
        this.Salary = Convert.ToDouble(Console.ReadLine());
      }
      catch (System.Exception e)
      {
        Console.WriteLine(e.Message);
        this.Salary = 0;
      }
    }
    public void setDepartment(Department department)
    {
      this.department = department;
      Console.WriteLine($"{this.Name} has been designated to {this.department.Name} department");
    }
    public void showDepartment()
    {
      Console.WriteLine($"Employee {this.Name} belongs to {this.department.Name} department");
    }
  }
}