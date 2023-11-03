using System;

namespace oop
{
  class Program
  {
    static void Main(string[] args)
    {
      Employee peter = new() // new Employee{}
      {
        Name = "Peter Parker",
        Age = 27,
        StartDate = new DateTime(1996, 01, 27)
      };
      Employee mary = new()
      {
        Name = "Mary Jane",
        Age = 29,
        StartDate = new DateTime()
      };
      Employee harry = new()
      {
        Name = "Harry Kane",
        Age = 25,
        StartDate = new DateTime()
      };
      Console.Clear();
      // peter.print();
      // peter.print("en-US");
      // peter.print(2);

      Department techDepartment = new(1, Department.Departments.Technology); // new Department()
      techDepartment.addEmployee(peter);
      techDepartment.showDepartment();

      Department hrDepartment = new(2, Department.Departments.HumanResources);
      hrDepartment.addEmployee(mary);
      hrDepartment.showDepartment();

      Department legalDepartment = new(4, Department.Departments.Legal);
      legalDepartment.addEmployee(harry);
      legalDepartment.showDepartment();

      harry.setDepartment(hrDepartment);
      mary.setDepartment(legalDepartment);
      peter.setDepartment(techDepartment);

      Company company = new("TSaytson Tech");
      company.addDepartment(hrDepartment);
      company.addDepartment(techDepartment);
      company.addDepartment(legalDepartment);
      company.showCompany();
    }
  }
}
