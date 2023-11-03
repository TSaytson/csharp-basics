using System;
using System.Collections.Generic;

namespace oop
{
  class Company
  {
    private string _name;
    public string Name
    {
      get => _name;
      set => _name = value;
    }
    public Company(string name)
    {
      if (name.Length < 2) throw new Exception("Company name is too short");
      this.Name = name;
    }
    public List<Department> departments = new List<Department>();

    public void addDepartment(Department department)
    {
      this.departments.Add(department);
    }

    public void showCompany()
    {
      Console.WriteLine("\n----------------------\n");
      Console.WriteLine($"Welcome to {this.Name} company");
      showDepartments();
      Console.WriteLine("\n----------------------\n");
    }

    public void showDepartments()
    {
      Console.WriteLine($"{this.Name} departments:");
      foreach (Department department in this.departments)
        Console.WriteLine($"{department.Name}");
    }
  }
}