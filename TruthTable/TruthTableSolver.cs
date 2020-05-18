using System.Collections.Generic;
using System.Linq;

namespace TruthTable
{
    public class TruthTableSolver
    {
        public List<TruthTableLineResult>  Solve(List<Input> inputs, string expression)
        {
            var InputValues = new Dictionary<string, string>();
            var TruthTableLines = new List<Dictionary<string, string>>();

            //var counter = 0;

            foreach (var value in inputs[0].PossibleValues)
            {
                var line = new Dictionary<string, string>();
                line.Add(inputs[0].Name, value);
                TruthTableLines.Add(line);
            }


            for (int i = 1; i < inputs.Count; i++)
            {
                var newTruthTable = new List<Dictionary<string, string>>();
                for (int l = 0; l < TruthTableLines.Count; l++)
                {

                    foreach (var value in inputs[i].PossibleValues)
                    {
                        newTruthTable.Add(new Dictionary<string, string>(TruthTableLines[l]));
                        newTruthTable[newTruthTable.Count() - 1].Add(inputs[i].Name, value);
                    }
                }
                TruthTableLines = newTruthTable;
            }


            var result = new List<TruthTableLineResult>();

            ExpressionSolver.Solver expSolver = new ExpressionSolver.Solver();

            foreach (var line in TruthTableLines)
            {
                expSolver.Parameters.Clear();
                foreach (var input in line)
                {
                    expSolver.Parameters.Add(input.Key, input.Value);
                }

                result.Add(new TruthTableLineResult(line, expSolver.Solve(expression)));
            }

            return result;
        }

        private bool ValuesAlreadyExists(List<Dictionary<string, string>> truthTableLines, Dictionary<string, string> inputValues)
        {
            foreach(var line in truthTableLines)
            {
                bool Exists = true;
                foreach(var lineValues in line)
                {
                    if (lineValues.Value != inputValues[lineValues.Key])
                        Exists = false;
                }
                if (Exists)
                    return true;
            }
            return false;
        }
    }
}
