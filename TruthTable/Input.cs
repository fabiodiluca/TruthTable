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
    }
}
