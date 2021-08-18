using System.Collections.Generic;

namespace TruthTable
{
    public interface ITruthTableSolver
    {
        List<TruthTableLineResult> Solve(List<Input> inputs, string expression);
    }
}