namespace CalculatorApp;

public class Calculator
{
 private readonly Tokenizer _tokenizer;
        private readonly Parser _parser;
        private readonly Evaluate _evaluator;

        public Calculator()
        {
            _tokenizer = new Tokenizer();
            _parser = new Parser();
            _evaluator = new Evaluate();
        }

        public double Evaluate(string expression)
        {
            var tokens = _tokenizer.Tokenize(expression);
            var rpn = _parser.Convert(tokens);
            return _evaluator.EvaluateRPN(rpn);
        }
    }

