using System.Collections.Generic;

namespace TruthTable
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
            var Inputs = inputs;
            var ValueChangeEvery = new Dictionary<Input, int>();
            var ValueCounters = new Dictionary<Input, int>();
            var CurrentValueIndex = new Dictionary<Input, int>();

            var permutations = inputs.CountPermutations();
            var changeValueEvery = permutations;
            foreach (var input in inputs)
            {
                changeValueEvery = changeValueEvery / input.PossibleValues.Count;
                ValueChangeEvery.Add(input, changeValueEvery);

                ValueCounters.Add(input, 0);
                CurrentValueIndex.Add(input, 0);
            }

            var ret = new List<TruthTableLine>();
            for (int cPermutation = 0; cPermutation < permutations; cPermutation++)
            {
                var line = new TruthTableLine();

                foreach (var input in Inputs)
                {
                    ValueCounters[input]++;
                    if (ValueCounters[input] > ValueChangeEvery[input])
                    {
                        ValueCounters[input] = 1;
                        CurrentValueIndex[input]++;
                        if (CurrentValueIndex[input] > (input.PossibleValues.Count - 1))
                            CurrentValueIndex[input] = 0;
                    }

                    var keyValuePair = new KeyValuePair<string, string>(
                        input.Name, 
                        input.PossibleValues[CurrentValueIndex[input]]
                    );

                    line.InputValues.Add(keyValuePair);
                }

                ret.Add(line);
            }
            return ret;
        }
    }
}
