using NUnit.Framework;
using TruthTable.Generators;

namespace TruthTable.UnitTests.Generators.Implementation
{
    public class TruthTableIterativeGeneratorTests: TruthTableGeneratorBaseTests
    {
        [SetUp]
        public void Setup()
        {
            truthTableGenerator = new TruthTableIterativeGenerator();
            inputs = _ABC_BinaryInputs();
        }

        [TestCase("FALSE", "FALSE", "FALSE")]
        [TestCase("FALSE", "FALSE", "TRUE")]
        [TestCase("FALSE", "TRUE", "FALSE")]
        [TestCase("FALSE", "TRUE", "TRUE")]
        [TestCase("TRUE", "FALSE", "FALSE")]
        [TestCase("TRUE", "FALSE", "TRUE")]
        [TestCase("TRUE", "TRUE", "FALSE")]
        [TestCase("TRUE", "TRUE", "TRUE")]
        public void TestABCBinaryInputTruthTable(string valueA, string valueB, string valueC)
        {
            _CheckForLineTruthTable(truthTableGenerator.Create(inputs), valueA, valueB, valueC);
        }
    }
}
