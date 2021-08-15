using System.Collections.Generic;

namespace TruthTable
{
    public class TruthTableSolver
    {
        public ITruthTableGenerator _truthTable;

        public TruthTableSolver(ITruthTableGenerator truthTable)
        {
            _truthTable = truthTable;
        }

        public List<TruthTableLineResult>  Solve(List<Input> inputs, string expression)
        {
            var truthTableLines = _truthTable.Create(inputs);

            var result = new List<TruthTableLineResult>();

            var expSolver = new ExpressionSolver.Solver();

            foreach (var line in truthTableLines)
            {
                expSolver.Parameters.Clear();
                foreach (var input in line.InputValues)
                {
                    expSolver.Parameters.Add(input.Key, input.Value);
                }

                result.Add(new TruthTableLineResult(line, expSolver.Solve(expression)));
            }

            return result;
        }

    }
}
