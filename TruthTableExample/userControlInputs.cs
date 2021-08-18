using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TruthTable;

namespace TruthTableExample
{
    public partial class userControlInputs : UserControl
    {
        public delegate void inputsChangedDelegate(List<Input> inputs);
        public event inputsChangedDelegate InputsChanged;

        private List<Input> _inputs = new List<Input>();

        public userControlInputs()
        {
            InitializeComponent();
        }

        private void btAddInput_Click(object sender, EventArgs e)
        {
            var originalInputName = txtInputName.Text;
            var inputName = originalInputName;

            if (_inputs.Any(x => x.Name == inputName))
            {
                MessageBox.Show("Input name already exist.");
                return;
            }

            _InputChanged();
        }

        private void btRemoveInput_Click(object sender, EventArgs e)
        {
            var inputName = txtInputName.Text;

            _inputs.Remove(_inputs.Where(x => x.Name == inputName).FirstOrDefault());
            listBoxInputs.Items.Remove(inputName);
            _InputChanged();
        }

        private void txtInputName_TextChanged(object sender, EventArgs e)
        {

        }

        private void _InputChanged()
        {
            if (InputsChanged != null)
                InputsChanged(_inputs);
        }

        private void listBoxInputs_SelectedValueChanged(object sender, EventArgs e)
        {
            txtInputName.Text = (string)listBoxInputs.SelectedItem;
        }

        public void AddInput(string name)
        {
            _inputs.Add(Input.BinaryInput(name));
            listBoxInputs.Items.Add(name);
            _InputChanged();
        }

        public void ClearInputs()
        {
            _inputs.Clear();
            listBoxInputs.Items.Clear();
            _InputChanged();
        }
    }
}
