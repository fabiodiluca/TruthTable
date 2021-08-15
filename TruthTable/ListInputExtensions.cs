using System.Collections.Generic;
using System.Linq;

namespace TruthTable
{
    public static class ListInputExtensions
    {
        public static int CountPermutations(this List<Input> inputsList) 
        {
            var acumulator = 1;
            foreach (var inputQuantity in inputsList.Select(x => x.PossibleValues.Count))
            {
                acumulator *= inputQuantity;
            }
            return acumulator;
        }
    }
}
