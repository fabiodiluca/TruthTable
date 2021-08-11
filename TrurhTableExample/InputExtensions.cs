using System.Collections.Generic;
using TruthTable;

namespace TrurhTableExample
{
    public static class InputExtensions
    {
        public static  Input BinaryInput(string name)
        {
            return new Input(name, new List<string> { "TRUE", "FALSE" });
        }
    }
}
