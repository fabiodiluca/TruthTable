using System.Collections.Generic;

namespace TruthTable
{
    public class TruthTableLine
    {
        public List<InputValue> InputValues { get; }

        public TruthTableLine()
        {
            InputValues = new List<InputValue>();
        }

        public TruthTableLine(string inputName, string inputValue)
        {
            InputValues = new List<InputValue>();
            InputValues.Add(new InputValue(inputName, inputValue));
        }

        public TruthTableLine(TruthTableLine line)
        {
            InputValues = new List<InputValue>();
            foreach (var pair in line.InputValues)
                InputValues.Add(pair);
        }
    }
}
