/*************************************************************************************

Name: Alex Wiley
Date: 11/16/2025
Assignment: SDC3210 Week 1 Project

This class represents a the HourlyEmployees class that was derived from the base class Employees. 
This class adds on the hourly pay rate for an employee that is paid by the hour. 

************************************************************************************/

public class HourlyEmployee : EmployeeClass
{
    public string Type {get; set;}
    
    public HourlyEmployee(int id, string name, string type)
    : base (id, name)
    {
        Type = type;
    }

    public override string GetEmployeeInfo()
    {
        return string.Format("{0} | Type: {1}", base.GetEmployeeInfo(), Type);
    }

    public override string ToString()
    {
        return GetEmployeeInfo();
    }
}