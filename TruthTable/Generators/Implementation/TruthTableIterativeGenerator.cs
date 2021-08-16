using System.Collections.Generic;

namespace TruthTable.Generators
{
    /// <summary>
    /// Iterative algorithm for creating the truth table. Faster compared to other recursion algorithm
    /// </summary>
    public class TruthTableIterativeGenerator : ITruthTableGenerator
    {

        public TruthTableIterativeGenerator()
        {

        }

        public List<TruthTableLine> Create(List<Input> inputs)
        {
            var counters = new TruthTableIterativeValueCounters(inputs);

            var permutations = inputs.CountPermutations();

            var ret = new List<TruthTableLine>();
            for (int cPermutation = 0; cPermutation < permutations; cPermutation++)
            {
                var line = new TruthTableLine();

                foreach (var input in inputs)
                {
                    counters.ValueChangeCounters[input]++;
                    if (counters.ValueChangeCounters[input] > counters.ValueShouldChangeEvery[input])
                    {
                        counters.ValueChangeCounters[input] = 1;
                        counters.CurrentValueIndex[input]++;
                        if (counters.CurrentValueIndex[input] > (input.PossibleValues.Count - 1))
                            counters.CurrentValueIndex[input] = 0;
                    }

                    var keyValuePair = new InputValue(
                        input.Name, 
                        input.PossibleValues[counters.CurrentValueIndex[input]]
                    );

                    line.InputValues.Add(keyValuePair);
                }

                ret.Add(line);
            }
            return ret;
        }
    }
}
