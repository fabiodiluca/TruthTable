using System.Collections.Generic;

namespace TruthTable
{
    public class TruthTableLineResult
    {
        public Dictionary<string, string> InputValues { get; internal set; }
        public string Result { get; internal set; }


        public TruthTableLineResult(Dictionary<string, string> inputValues, string result)
        {
            this.InputValues = inputValues;
            this.Result = result;
        }
    }
}
