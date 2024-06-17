namespace CalculatorApp;

public class Evaluate
{
public double EvaluateRPN(List<string> rpn)
        {
            var stack = new Stack<double>();

            foreach (var token in rpn)
            {
                if (double.TryParse(token, out var number))
                {
                    stack.Push(number);
                }
                else
                {
                    var b = stack.Pop();
                    var a = stack.Pop();
                    stack.Push(token switch
                    {
                        "+" => a + b,
                        "-" => a - b,
                        "*" => a * b,
                        "/" => a / b,
                        _ => throw new NotSupportedException($"Operator {token} is not supported.")
                    });
                }
            }

            return stack.Pop();
        }
    }

