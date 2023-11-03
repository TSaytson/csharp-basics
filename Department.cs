using System;
using System.Collections.Generic;

namespace oop
{
  class Department
  {
    public List<Employee> employees = new List<Employee>();

    private Company _company;
    public Company Company
    {
      get => _company;
      set => _company = value;
    }
    public enum Departments
    {
      Technology,
      HumanResources,
      Finances,
      Marketing,
      Legal
    }
    private ushort _id;
    public ushort Id
    {
      get => _id;
      set => _id = value;
    }
    private Departments _name;
    public Departments Name
    {
      get => _name;
      set => _name = value;
    }
    public Department(ushort id, Departments name)
    {
      this.Id = id;
      this.Name = name;
    }

    public void addEmployee(Employee employee)
    {
      this.employees.Add(employee);
    }

    public void showDepartment()
    {
      Console.WriteLine("\n----------------------\n");
      Console.WriteLine($"Welcome to {this.Name} department");
      showEmployees();
      Console.WriteLine("\n----------------------\n");
    }

    public void showEmployees()
    {
      Console.WriteLine($"{this.Name} department employees:");
      foreach (Employee employee in this.employees)
        Console.WriteLine($"Name: {employee.Name}\t Age: {employee.Age}\t"
        + $"StartDate: {employee.StartDate:dd/MM/yyyy}");
    }

    public void showCompany()
    {
      Console.WriteLine("\n----------------------\n");
      Console.WriteLine($"Welcome to {this.Company}");
      Console.WriteLine("\n----------------------\n");
    }
  }
}