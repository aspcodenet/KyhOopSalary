namespace KyhOopSalary;

public class Employee
{
    private string _namn;
    protected DateTime _birthDate;
    protected DateTime _employeeDate;
    
    public Employee(string namn, DateTime birthDate, DateTime employeeDate)
    {
        _namn = namn;
        _birthDate = birthDate;
        _employeeDate = employeeDate;
    }

    public virtual int CalculateSalary()
    {
        return 0;
    }

}