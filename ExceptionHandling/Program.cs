using ExceptionHandling.Models;

var Thilina = new Employee()
{
    Id = 01,
    Name = "Thilina",
    BasicSalary = 100000,
    LoanInstalAmount = 200000

};

try
{
    Thilina.CalculateNetSalary();
}
catch(LoanGraterthanBasicException ex)
{
    Console.WriteLine($"Error calculating net salary { ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Something wen to wrong {ex.Message}");
}

Console.WriteLine($"{Thilina.Name} your net salary is {Thilina.BasicSalary}");
