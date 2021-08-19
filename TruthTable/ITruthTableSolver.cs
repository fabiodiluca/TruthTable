using System.Collections.Generic;

namespace TruthTable
{
    public interface ITruthTableSolver
    {
        List<TruthTableLine> Solve(List<Input> inputs, string expression);
    }
}