namespace KyhOopSalary;

public class App
{
    public void Run()
    {
        var stefan = new MonthlyEmployee("Stefan", new DateTime(1972, 8, 3), new DateTime(1980, 1, 1), 10000);
        var oliver = new HourlyEmployee("Oliver", new DateTime(2008, 5,28), new DateTime(2016, 1, 1), 50,10);

        var listOfEmployees = new List<Employee>();
        listOfEmployees.Add(stefan);
        listOfEmployees.Add(oliver);
        foreach (var employee in listOfEmployees)
        {
            Console.WriteLine($"{employee.CalculateSalary()}");
        }

    }
}