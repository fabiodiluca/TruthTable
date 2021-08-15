namespace TruthTable
{
    public class TruthTableLineResult
    {
        public TruthTableLine InputLine { get; internal set; }
        public string Result { get; internal set; }

        public TruthTableLineResult(TruthTableLine inputLine, string result)
        {
            this.InputLine = inputLine;
            this.Result = result;
        }
    }
}
