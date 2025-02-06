using Microsoft.AspNetCore.Mvc;

public class AdvancedOperationsController : Controller
{
    public IActionResult Square(double num) => Content($"Square of {num}: {num * num}");

    public IActionResult SquareRoot(double num)
    {
        if (num < 0)
            return Content("Error: Cannot calculate the square root of a negative number.");
        return Content($"Square root of {num}: {Math.Sqrt(num)}");
    }

    public IActionResult Power(double num, double exponent) =>
        Content($"{num} raised to the power of {exponent}: {Math.Pow(num, exponent)}");

    public IActionResult Index(string operation, double num, double? exponent = null)
    {
        return operation.ToLower() switch
        {
            "square" => Square(num),
            "squareroot" => SquareRoot(num),
            "power" => exponent.HasValue ? Power(num, exponent.Value) : Content("Error: Exponent is required for the power operation."),
            _ => Content("Error: Invalid operation. Use square, squareroot, or power.")
        };
    }
}
