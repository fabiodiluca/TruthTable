using System.Collections.Generic;
using TruthTable;

namespace TruthTableExample
{
    public static class InputExtensions
    {
        public static  Input BinaryInput(string name)
        {
            return new Input(name, new List<string> { "TRUE", "FALSE" });
        }
    }
}
