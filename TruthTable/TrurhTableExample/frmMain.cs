using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using TruthTable;

namespace TrurhTableExample
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            //var a = new Input("A", new List<string>() { "FALSE", "TRUE" });
            //var b = new Input("B", new List<string>() { "FALSE", "TRUE" });
            //var c = new Input("C", new List<string>() { "FALSE", "TRUE" });
            //var d = new Input("D", new List<string>() { "FALSE", "TRUE" });

            //var inputList = new List<Input> {a , b, c, d};

            //TruthTableSolver solver = new TruthTableSolver();
            //var result = solver.Solve(inputList, "((A OR B) AND C) OR D");

            var a = new Input("PratoPrincipal", new List<string>() { "'Arroz'", "'Feijao'", "'Bife'" });
            var b = new Input("Acompanhamento", new List<string>() { "'Batata Frita'", "'Pure Batata'" });

            var inputList = new List<Input> { a, b };

            TruthTableSolver solver = new TruthTableSolver();
            var result = solver.Solve(inputList, "(PratoPrincipal='Arroz')AND(Acompanhamento='Pure Batata')");


            textBox1.Text = truthTableString(result).ToString();
        }

        private StringBuilder truthTableString(List<TruthTableLineResult> result)
        {
            StringBuilder sbTable = new StringBuilder();
            foreach (var input in result[0].InputValues)
            {
                sbTable.Append(input.Key + "\t");
            }
            sbTable.Append("Result");
            sbTable.Append("\r\n");

            foreach (var line in result)
            {
                foreach (var input in line.InputValues)
                {
                    sbTable.Append(input.Value + "\t");
                }
                sbTable.Append(line.Result);
                sbTable.Append("\r\n");
            }
            return sbTable;
        }
    }
}
