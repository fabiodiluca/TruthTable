using System.Collections.Generic;
using System.Linq;

namespace TruthTable.Generators
{
    /// <summary>
    /// Recursive algorithm for creating the table
    /// </summary>
    public class TruthTableRecursiveGenerator : ITruthTableGenerator
    {
        public TruthTableRecursiveGenerator()
        {

        }

        public List<TruthTableLineInputs> Create(List<Input> inputs)
        {
            var truthTableLines = new List<TruthTableLineInputs>();

            foreach (var value in inputs[0].PossibleValues)
            {
                var line = new TruthTableLineInputs(inputs[0].Name, value);
                truthTableLines.Add(line);
            }

            for (int i = 1; i < inputs.Count; i++)
            {
                var tmpTruthTable = new List<TruthTableLineInputs>();
                for (int l = 0; l < truthTableLines.Count; l++)
                {
                    foreach (var value in inputs[i].PossibleValues)
                    {
                        tmpTruthTable.Add(new TruthTableLineInputs(truthTableLines[l]));
                        tmpTruthTable.Last().InputValues.Add(new InputValue(inputs[i].Name, value));
                    }
                }
                truthTableLines = tmpTruthTable;
            }

            return truthTableLines;
        }
    }
}
