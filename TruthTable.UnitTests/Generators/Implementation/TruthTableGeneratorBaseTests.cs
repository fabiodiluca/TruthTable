using System.Collections.Generic;
using System.Linq;
using TruthTable.Generators;

namespace TruthTable.UnitTests.Generators.Implementation
{
    public class TruthTableGeneratorBaseTests
    {
        protected ITruthTableGenerator truthTableGenerator;
        protected List<Input> inputs;

        /// <summary>
        /// Considers and A,B,C input binary truth table
        /// </summary>
        /// <param name="lines"></param>
        /// <param name="valueA"></param>
        /// <param name="valueB"></param>
        /// <param name="valueC"></param>
        protected void _CheckForLineTruthTable(List<TruthTableLineInputs> lines, string valueA, string valueB, string valueC)
        {
            lines.Single(x =>
                x.InputValues.Any(z => z.InputName == "A" && z.Value == valueA) &&
                x.InputValues.Any(z => z.InputName == "B" && z.Value == valueB) &&
                x.InputValues.Any(z => z.InputName == "C" && z.Value == valueC)
            );
        }

        protected List<Input> _ABC_BinaryInputs()
        {
            var list = new List<Input>();
            list.Add(Input.BinaryInput("A"));
            list.Add(Input.BinaryInput("B"));
            list.Add(Input.BinaryInput("C"));
            return list;
        }
    }
}
