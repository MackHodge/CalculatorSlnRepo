namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            Console.WriteLine("Enter an expression (ex, 3 * 9 or 3 + 5 * (2 - 8)):");
            var input = Console.ReadLine();
            try
            {
                var result = calculator.Evaluate(input);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}