using Microsoft.AspNetCore.Mvc;

public class OperationsController : Controller
{
    public IActionResult Add(double num1, double num2) => Content($"Result: {num1 + num2}");

    public IActionResult Subtract(double num1, double num2) => Content($"Result: {num1 - num2}");

    public IActionResult Multiply(double num1, double num2) => Content($"Result: {num1 * num2}");

    public IActionResult Divide(double num1, double num2)
    {
        if (num2 == 0)
            return Content("Error: Division by zero is not allowed.");
        return Content($"Result: {num1 / num2}");
    }

    public IActionResult Index(string operation, double num1, double num2)
    {
        return operation.ToLower() switch
        {
            "add" => Add(num1, num2),
            "subtract" => Subtract(num1, num2),
            "multiply" => Multiply(num1, num2),
            "divide" => Divide(num1, num2),
            _ => Content("Error: Invalid operation. Use add, subtract, multiply, or divide.")
        };
    }
}
