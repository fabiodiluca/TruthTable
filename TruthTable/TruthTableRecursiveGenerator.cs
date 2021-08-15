﻿using System.Collections.Generic;
using System.Linq;

namespace TruthTable
{
    /// <summary>
    /// Recursive algorithm for creating the table
    /// </summary>
    public class TruthTableRecursiveGenerator : ITruthTableGenerator
    {
        public TruthTableRecursiveGenerator()
        {

        }

        public List<TruthTableLine> Create(List<Input> inputs)
        {
            var truthTableLines = new List<TruthTableLine>();

            foreach (var value in inputs[0].PossibleValues)
            {
                var line = new TruthTableLine(inputs[0].Name, value);
                truthTableLines.Add(line);
            }

            for (int i = 1; i < inputs.Count; i++)
            {
                var tmpTruthTable = new List<TruthTableLine>();
                for (int l = 0; l < truthTableLines.Count; l++)
                {
                    foreach (var value in inputs[i].PossibleValues)
                    {
                        tmpTruthTable.Add(new TruthTableLine(truthTableLines[l]));
                        tmpTruthTable.Last().InputValues.Add(new KeyValuePair<string, string>(inputs[i].Name, value));
                    }
                }
                truthTableLines = tmpTruthTable;
            }

            return truthTableLines;
        }
    }
}