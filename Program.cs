class Project
{
    static void Main(string[] args)
    {
        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.WriteLine("\t\tAlex Wiley - Employee Management Project");
        Console.WriteLine("--------------------------------------------------------------------------------");

        EmployeeManager m = new EmployeeManager();
        HourlyEmployee e1 = new HourlyEmployee(101, "John Basilone", "Hourly");

        m.AddEmployee(e1);

        m.DisplayEmployees();
    
    }
}