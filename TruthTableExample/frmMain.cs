using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TruthTable;
using TruthTable.Generators;

namespace TruthTableExample
{
    public partial class frmMain : Form
    {
        List<Input> _inputs = new List<Input>();
        TruthTableSolver solver = new TruthTableSolver(new TruthTableIterativeGenerator());
        public frmMain()
        {
            InitializeComponent();
            userControlInputs1.InputsChanged += _UserControlInputs_Changed;

            //var a = new Input("PratoPrincipal", new List<string>() { "'Arroz'", "'Feijao'", "'Bife'" });
            //var b = new Input("Acompanhamento", new List<string>() { "'Batata Frita'", "'Pure Batata'" });

            //var inputList = new List<Input> { a, b };

            //var solver = new TruthTableSolver();
            //var result = solver.Solve(inputList, "(PratoPrincipal='Arroz')AND(Acompanhamento='Pure Batata')");

            //textBox1.Text = truthTableString(result).ToString();
        }

        private void _UserControlInputs_Changed(List<Input> inputs)
        {
            _inputs = inputs;
        }

        private StringBuilder truthTableString(List<TruthTableLine> result)
        {
            var sbTable = new StringBuilder();
            foreach (var input in result[0].InputLine.InputValues)
            {
                sbTable.Append(input.InputName + "\t");
            }
            sbTable.Append("Result");
            sbTable.Append("\r\n");

            foreach (var line in result)
            {
                foreach (var input in line.InputLine.InputValues)
                {
                    sbTable.Append(input.Value + "\t");
                }
                sbTable.Append(line.Result);
                sbTable.Append("\r\n");
            }
            return sbTable;
        }

        private void btWriteTable_Click(object sender, System.EventArgs e)
        {
            var result = solver.Solve(_inputs, txtExpression.Text);
            textBox1.Text = truthTableString(result).ToString();
        }

        private void menuItemExamplesAnd_Click(object sender, System.EventArgs e)
        {
            userControlInputs1.ClearInputs();
            userControlInputs1.AddInput("A");
            userControlInputs1.AddInput("B");
            userControlInputs1.AddInput("C");
            txtExpression.Text = "A AND B AND C";
            btWriteTable_Click(null, null);
        }

        private void menuItemExamplesOr_Click(object sender, System.EventArgs e)
        {
            userControlInputs1.ClearInputs();
            userControlInputs1.AddInput("A");
            userControlInputs1.AddInput("B");
            userControlInputs1.AddInput("C");
            userControlInputs1.AddInput("D");
            userControlInputs1.AddInput("E");
            txtExpression.Text = "A OR B OR C OR D OR E";
            btWriteTable_Click(null, null);
        }

        private void menuItemExamplesComplex_Click(object sender, System.EventArgs e)
        {
            userControlInputs1.ClearInputs();
            userControlInputs1.AddInput("A");
            userControlInputs1.AddInput("B");
            userControlInputs1.AddInput("C");
            userControlInputs1.AddInput("D");
            txtExpression.Text = "((A OR B) AND C) OR D";
            btWriteTable_Click(null, null);
        }
    }
}
