using System.Diagnostics;
using System.Text.Json;
using NCalc; // NCalc library for expression evaluation

namespace HorseScale.services
{
    internal static class Formula
    {
        // Dictionary to store the formula functions
        public static Dictionary<string, Func<double, double, double, double>> _formulas  = new();

        // Load formulas from a JSON file
        public static void LoadFormulasFromJson(string filePath)
        {
            // Read the JSON file
            string json = File.ReadAllText(filePath);

            var formulaStrings = JsonSerializer.Deserialize<Dictionary<string, string>>(json);

            // Convert the string formulas into Func<double, double, double, double>
            _formulas = new Dictionary<string, Func<double, double, double, double>>();
            foreach (var kvp in formulaStrings)
            {
                _formulas[kvp.Key] = CreateFormulaFunction(kvp.Value);
            }
        }

        // Create a Func<double, double, double, double> from a formula string
        private static Func<double, double, double, double> CreateFormulaFunction(string formula)
        {
            var expression = new Expression(formula);

            // Define the function that evaluates the expression
            return (m, x1, x2) =>
            {
                expression.Parameters["m"] = m;
                expression.Parameters["x1"] = x1;
                expression.Parameters["x2"] = x2;

                var result = expression.Evaluate();
                return Convert.ToDouble(result);
            };
        }

        // Get a formula function by key
        public static Func<double, double, double, double> GetFormula(string key)
        {
            if (_formulas == null)
            {
                throw new InvalidOperationException("Formulas have not been loaded. Call LoadFormulasFromJson first.");
            }

            if (_formulas.TryGetValue(key, out var formula))
            {
                return formula;
            }

            throw new KeyNotFoundException($"Formula with key '{key}' not found.");
        }
    }
}