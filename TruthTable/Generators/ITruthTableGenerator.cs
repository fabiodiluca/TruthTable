using System.Collections.Generic;

namespace TruthTable.Generators
{
    public interface ITruthTableGenerator
    {
        List<TruthTableLine> Create(List<Input> inputs);
    }
}