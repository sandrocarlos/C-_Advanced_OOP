/*************************************************************************************

Name: Alex Wiley
Date: 11/16/2025
Assignment: SDC3210 Week 1 Project

This class is an example of composition by showing a class that manages a collection
of employees.
************************************************************************************/

public class EmployeeManager
{
    private List<EmployeeClass> employees = new List<EmployeeClass>();

    public void AddEmployee(EmployeeClass e)
    {
        employees.Add(e);
    }

    public void DisplayEmployees()
    {
        Console.WriteLine("\n*** Current Employees ***\n");
        foreach (var emp in employees)
        {
            Console.WriteLine(emp.GetEmployeeInfo());
        }
    }
}