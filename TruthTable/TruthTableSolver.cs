using System.Collections.Generic;
using TruthTable.Generators;

namespace TruthTable
{
    public class TruthTableSolver
    {
        public ITruthTableGenerator _truthTable;

        public TruthTableSolver(ITruthTableGenerator truthTable)
        {
            _truthTable = truthTable;
        }

        public List<TruthTableLineResult> Solve(List<Input> inputs, string expression)
        {
            var truthTableLines = _truthTable.Create(inputs);

            var result = new List<TruthTableLineResult>();

            var expSolver = new ExpressionSolver.Solver();

            foreach (var line in truthTableLines)
            {
                result.Add(_SolveLine(expSolver, line, expression));
            }

            return result;
        }

        private TruthTableLineResult _SolveLine(ExpressionSolver.Solver solver, TruthTableLine line, string expression)
        {
            solver.Parameters.Clear();
            foreach (var input in line.InputValues)
            {
                solver.Parameters.Add(input.Name, input.Value);
            }
            return new TruthTableLineResult(line, solver.Solve(expression));
        }
    }
}
