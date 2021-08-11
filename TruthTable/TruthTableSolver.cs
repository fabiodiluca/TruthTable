using System.Collections.Generic;
using System.Linq;

namespace TruthTable
{
    public class TruthTableSolver
    {
        public List<TruthTableLineResult>  Solve(List<Input> inputs, string expression)
        {
            var truthTableLines = new List<Dictionary<string, string>>();

            foreach (var value in inputs[0].PossibleValues)
            {
                var line = new Dictionary<string, string>();
                line.Add(inputs[0].Name, value);
                truthTableLines.Add(line);
            }

            for (int i = 1; i < inputs.Count; i++)
            {
                var newTruthTable = new List<Dictionary<string, string>>();
                for (int l = 0; l < truthTableLines.Count; l++)
                {
                    foreach (var value in inputs[i].PossibleValues)
                    {
                        newTruthTable.Add(new Dictionary<string, string>(truthTableLines[l]));
                        newTruthTable[newTruthTable.Count() - 1].Add(inputs[i].Name, value);
                    }
                }
                truthTableLines = newTruthTable;
            }

            var result = new List<TruthTableLineResult>();

            var expSolver = new ExpressionSolver.Solver();

            foreach (var line in truthTableLines)
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

    }
}
