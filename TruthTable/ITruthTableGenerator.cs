using System.Collections.Generic;

namespace TruthTable
{
    public interface ITruthTableGenerator
    {
        List<TruthTableLine> Create(List<Input> inputs);
    }
}