namespace TruthTable
{
    public class InputValue
    {
        public InputValue(string name, string value)
        {
            InputName = name;
            Value = value;
        }

        public string InputName { get; }
        public string Value { get; }

    }
}
