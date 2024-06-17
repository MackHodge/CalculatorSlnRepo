namespace CalculatorApp;

public class Tokenizer
{
public List<string> Tokenize(string expression)
        {
            var tokens = new List<string>();
            var number = "";
            for (int i = 0; i < expression.Length; i++)
            {
                if (char.IsDigit(expression[i]) || expression[i] == '.')
                {
                    number += expression[i];
                }
                else
                {
                    if (number.Length > 0)
                    {
                        tokens.Add(number);
                        number = "";
                    }
                    if (!char.IsWhiteSpace(expression[i]))
                    {
                        tokens.Add(expression[i].ToString());
                    }
                }
            }
            if (number.Length > 0)
            {
                tokens.Add(number);
            }
            return tokens;
        }
    }

