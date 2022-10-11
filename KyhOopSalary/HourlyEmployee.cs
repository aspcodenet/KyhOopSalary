namespace KyhOopSalary;

public class HourlyEmployee : Employee
{
    private int _hourlySalary;
    private readonly int _hoursWorked;

    public HourlyEmployee(string namn, DateTime birthDate, DateTime employeeDate, int hourlySalary, int hoursWorked)
        :base(namn, birthDate, employeeDate)
    {
        _hourlySalary = hourlySalary;
        _hoursWorked = hoursWorked;
    }

    public override int CalculateSalary()
    {
        return _hourlySalary * _hoursWorked;
    }


}