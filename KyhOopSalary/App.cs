namespace KyhOopSalary;

public class App
{
    public void Run()
    {
        var stefan = new MonthlyEmployee("Stefan", new DateTime(1972, 8, 3), new DateTime(1980, 1, 1), 10000);
        Console.WriteLine($"Lönen blev {stefan.CalculateSalary()}");
        //var oliver = new Employee("Oliver", new DateTime(2008, 5,28), new DateTime(2016, 1, 1), 5000);
        //Console.WriteLine($"Lönen blev {oliver.CalculateSalary()}");

    }
}