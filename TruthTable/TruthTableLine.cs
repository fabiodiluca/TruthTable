namespace TruthTable
{
    public class TruthTableLine
    {
        public TruthTableLineInputs InputLine { get; internal set; }
        public string Result { get; internal set; }

        public TruthTableLine(TruthTableLineInputs inputLine, string result)
        {
            this.InputLine = inputLine;
            this.Result = result;
        }
    }
}
