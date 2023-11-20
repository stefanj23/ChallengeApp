using ChallengeApp;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee emp1 = new Employee("Norbert", "S", 36);
        Employee emp2 = new Employee("Przemek", "S", 30);
        Employee emp3 = new Employee("Marta", "Cz", 38);

        emp1.AddScore(5);
        emp1.AddScore(1);
        emp1.AddScore(10);
        emp1.AddScore(7);
        emp1.AddScore(3);

        emp2.AddScore(3);
        emp2.AddScore(6);
        emp2.AddScore(6);
        emp2.AddScore(9);
        emp2.AddScore(2);


        emp3.AddScore(10);
        emp3.AddScore(10);
        emp3.AddScore(9);
        emp3.AddScore(7);
        emp3.AddScore(5);

        List<Employee> employees = new List<Employee>()
{
    emp1, emp2, emp3
};


        int maxResult = 0;
        Employee employeeWithMaxResult = null;

        foreach (var emp in employees)
        {
            if (emp1.Result > maxResult)
            {
                employeeWithMaxResult = emp1;

            }
            else if (emp2.Result > maxResult)
            {
                employeeWithMaxResult = emp2;
                maxResult = emp2.Result;
            }
            if (emp3.Result > maxResult)
            {
                employeeWithMaxResult = emp3;
                maxResult = emp3.Result;
            }
        }

        Console.WriteLine($"Największą ilość punktów: {maxResult} zdobył/a {employeeWithMaxResult.FullInfo} lat.");
    }
}

                