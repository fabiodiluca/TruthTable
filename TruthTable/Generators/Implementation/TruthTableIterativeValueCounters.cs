using System.Collections.Generic;

namespace TruthTable.Generators
{
    internal class TruthTableIterativeValueCounters
    {
        public Dictionary<Input, int> ValueShouldChangeEvery = new Dictionary<Input, int>();
        public Dictionary<Input, int> ValueChangeCounters = new Dictionary<Input, int>();
        public Dictionary<Input, int> CurrentValueIndex = new Dictionary<Input, int>();

        public TruthTableIterativeValueCounters(List<Input> inputs)
        {
            var permutations = inputs.CountPermutations();
            var changeValueEvery = permutations;
            foreach (var input in inputs)
            {
                changeValueEvery = changeValueEvery / input.PossibleValues.Count;
                ValueShouldChangeEvery.Add(input, changeValueEvery);
                ValueChangeCounters.Add(input, 0);
                CurrentValueIndex.Add(input, 0);
            }
        }
    }
}
