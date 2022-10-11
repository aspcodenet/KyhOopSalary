namespace KyhOopSalary;

public class Employee
{
    private string _namn;
    private DateTime _birthDate;
    private DateTime _employeeDate;
    private int _monthlySalary;

    public Employee(string namn, DateTime birthDate, DateTime employeeDate, int monthlySalary)
    {
        _namn = namn;
        _birthDate = birthDate;
        _employeeDate = employeeDate;
        _monthlySalary = monthlySalary;
    }

    public int CalculateSalary()
    {
        var salary = _monthlySalary;
        if (DateTime.Now.Year - _birthDate.Year >= 50)
        {
            salary = Convert.ToInt32(salary * 1.02);
        }
        if (DateTime.Now.Year - _employeeDate.Year >= 10)
        {
            salary = Convert.ToInt32(salary * 1.02);
        }
        return salary;
    }
}