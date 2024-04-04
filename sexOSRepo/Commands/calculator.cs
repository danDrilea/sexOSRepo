using System;
using System.Collections.Generic;
using sexOSKernel.Commands;

namespace sexOSKernel.Commands
{
    public class CalculatorCommand : Command
    {
        public CalculatorCommand(String name, String description) : base(name, description) { }

        public override String Execute(String[] args)
        {
            string expression = string.Join(" ", args);
            try
            {
                double result = EvaluateExpression(expression);
                return $"Result: {result}";
            }
            catch (Exception ex)
            {
                return $"Error evaluating expression: {ex.Message}";
            }
        }

        private double EvaluateExpression(string expression)
        {
            List<string> tokens = new List<string>(expression.Split(' '));
            // Process * and /
            for (int i = 1; i < tokens.Count - 1; i += 2)
            {
                if (tokens[i] == "*" || tokens[i] == "/")
                {
                    double left = Convert.ToDouble(tokens[i - 1]);
                    double right = Convert.ToDouble(tokens[i + 1]);
                    double result = tokens[i] == "*" ? left * right : left / right;

                    tokens[i - 1] = result.ToString();
                    tokens.RemoveAt(i); // Remove the operator
                    tokens.RemoveAt(i); // Remove the next operand
                    i -= 2; // Step back to recheck for new * or /
                }
            }
            // Process + and -
            double finalResult = Convert.ToDouble(tokens[0]);
            for (int i = 1; i < tokens.Count - 1; i += 2)
            {
                double next = Convert.ToDouble(tokens[i + 1]);
                finalResult = tokens[i] == "+" ? finalResult + next : finalResult - next;
            }
            return finalResult;
        }
    }
}