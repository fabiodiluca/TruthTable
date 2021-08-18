using System.Collections.Generic;

namespace TruthTable
{
    public class Input
    {
        public List<string> PossibleValues { get; internal set; }
        public string Name { get; internal set; }

        public Input(string name, List<string> possibleValues)
        {
            this.Name = name;
            PossibleValues = possibleValues;
        }

        public static Input BinaryInput(string name)
        {
            return new Input(name, new List<string> { "TRUE", "FALSE" });
        }
    }
}
