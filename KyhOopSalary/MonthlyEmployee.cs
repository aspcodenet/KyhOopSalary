namespace KyhOopSalary;

public class MonthlyEmployee : Employee
{
    private int _monthlySalary;

    public MonthlyEmployee(string namn, DateTime birthDate, DateTime employeeDate, int monthlySalary)
        :base(namn, birthDate, employeeDate)
    {
        _monthlySalary = monthlySalary;
    }
    public override int CalculateSalary()
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