using System.Collections.Generic;
using TruthTable.Generators;

namespace TruthTable
{
    public class TruthTableSolver : ITruthTableSolver
    {
        public ITruthTableGenerator _truthTable;

        public TruthTableSolver(ITruthTableGenerator truthTable)
        {
            _truthTable = truthTable;
        }

        public List<TruthTableLine> Solve(List<Input> inputs, string expression)
        {
            var truthTableLines = _truthTable.Create(inputs);

            var result = new List<TruthTableLine>();

            var expSolver = new ExpressionSolver.Solver();

            foreach (var line in truthTableLines)
            {
                result.Add(_SolveLine(expSolver, line, expression));
            }

            return result;
        }

        private TruthTableLine _SolveLine(ExpressionSolver.Solver solver, TruthTableLineInputs line, string expression)
        {
            solver.Parameters.Clear();
            foreach (var input in line.InputValues)
            {
                solver.Parameters.Add(input.InputName, input.Value);
            }
            return new TruthTableLine(line, solver.Solve(expression));
        }
    }
}
