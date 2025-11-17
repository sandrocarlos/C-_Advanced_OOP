/*************************************************************************************

Name: Alex Wiley
Date: 11/16/2025
Assignment: SDC3210 Week 1 Project

This class represents a the base class for all Employees. 

************************************************************************************/

public class EmployeeClass
{
    public int EmployeeID {get; set;}
    public string Name {get; set;}

    public EmployeeClass(int id, string name)
    {
        EmployeeID = id;
        Name = name;
    }

    public virtual string GetEmployeeInfo()
    {
        return string.Format("ID: {0} | Name: {1}", EmployeeID, Name);
    }
}