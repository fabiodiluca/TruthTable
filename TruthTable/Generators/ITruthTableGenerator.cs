using System.Collections.Generic;

namespace TruthTable.Generators
{
    public interface ITruthTableGenerator
    {
        List<TruthTableLineInputs> Create(List<Input> inputs);
    }
}