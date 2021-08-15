using System.Collections.Generic;

namespace TruthTable
{
    public class TruthTableLine
    {
        public List<KeyValuePair<string, string>> InputValues { get; }

        public TruthTableLine()
        {
            InputValues = new List<KeyValuePair<string, string>>();
        }

        public TruthTableLine(string inputName, string inputValue)
        {
            InputValues = new List<KeyValuePair<string, string>>();
            InputValues.Add(new KeyValuePair<string, string>(inputName, inputValue));
        }

        public TruthTableLine(TruthTableLine line)
        {
            InputValues = new List<KeyValuePair<string, string>>();
            foreach (var pair in line.InputValues)
                InputValues.Add(pair);
        }
    }
}
