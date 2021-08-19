using System.Collections.Generic;

namespace TruthTable
{
    public class TruthTableLineInputs
    {
        public List<InputValue> InputValues { get; }

        public TruthTableLineInputs()
        {
            InputValues = new List<InputValue>();
        }

        public TruthTableLineInputs(string inputName, string inputValue)
        {
            InputValues = new List<InputValue>();
            InputValues.Add(new InputValue(inputName, inputValue));
        }

        public TruthTableLineInputs(TruthTableLineInputs line)
        {
            InputValues = new List<InputValue>();
            foreach (var pair in line.InputValues)
                InputValues.Add(pair);
        }
    }
}
