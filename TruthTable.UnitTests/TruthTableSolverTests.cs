using FluentAssertions;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TruthTable.Generators;

namespace TruthTable.UnitTests
{
    public class TruthTableSolverTests
    {
        List<TruthTableLine> tableLines;
        Mock<ITruthTableGenerator> truthTableGenerator;
        TruthTableSolver truthTableSolver;

        [SetUp]
        public void Setup()
        {
            tableLines = _TableLines();

            truthTableGenerator = new Mock<ITruthTableGenerator>();
            truthTableGenerator
                .Setup(x => x.Create(It.IsAny<List<Input>>()))
                .Returns(tableLines);
        }

        /// <summary>
        /// Adding only one line for testing
        /// </summary>
        /// <returns></returns>
        private List<TruthTableLine> _TableLines()
        {
            var lines = new List<TruthTableLine>();
            var line = new TruthTableLine();
            line.InputValues.Add(new InputValue("A", "FALSE"));
            line.InputValues.Add(new InputValue("B", "FALSE"));
            line.InputValues.Add(new InputValue("C", "FALSE"));
            line.InputValues.Add(new InputValue("D", "FALSE"));
            line.InputValues.Add(new InputValue("E", "TRUE"));
            line.InputValues.Add(new InputValue("F", "TRUE"));

            lines.Add(line);

            return lines;
        }

        [TestCase("A AND B", "FALSE")]
        [TestCase("B AND C", "FALSE")]
        [TestCase("C AND D", "FALSE")]
        [TestCase("D AND E", "FALSE")]
        [TestCase("E AND F", "TRUE")]
        [TestCase("F AND E", "TRUE")]
        [TestCase("A OR B OR C OR D", "FALSE")]
        [TestCase("A OR B OR C OR D OR E", "TRUE")]
        [TestCase("A OR B OR C OR D OR F", "TRUE")]
        [TestCase("D OR E", "TRUE")]
        [TestCase("E OR F", "TRUE")]
        [TestCase("F OR E", "TRUE")]
        public void ShouldEvaluateCorrectly(string expression, string expectedResult)
        {
            truthTableSolver = new TruthTableSolver(truthTableGenerator.Object);
            var table = truthTableSolver.Solve(new List<Input>(), expression);
            table.Single().Result.Should().Be(expectedResult);
        }
    }
}