
namespace TruthTableExample
{
    partial class userControlInputs
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btRemoveInput = new System.Windows.Forms.Button();
            this.btAddInput = new System.Windows.Forms.Button();
            this.txtInputName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxInputs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btRemoveInput
            // 
            this.btRemoveInput.Location = new System.Drawing.Point(48, 55);
            this.btRemoveInput.Name = "btRemoveInput";
            this.btRemoveInput.Size = new System.Drawing.Size(32, 23);
            this.btRemoveInput.TabIndex = 12;
            this.btRemoveInput.Text = "-";
            this.btRemoveInput.UseVisualStyleBackColor = true;
            this.btRemoveInput.Click += new System.EventHandler(this.btRemoveInput_Click);
            // 
            // btAddInput
            // 
            this.btAddInput.Location = new System.Drawing.Point(9, 55);
            this.btAddInput.Name = "btAddInput";
            this.btAddInput.Size = new System.Drawing.Size(32, 23);
            this.btAddInput.TabIndex = 11;
            this.btAddInput.Text = "+";
            this.btAddInput.UseVisualStyleBackColor = true;
            this.btAddInput.Click += new System.EventHandler(this.btAddInput_Click);
            // 
            // txtInputName
            // 
            this.txtInputName.Location = new System.Drawing.Point(9, 29);
            this.txtInputName.Name = "txtInputName";
            this.txtInputName.Size = new System.Drawing.Size(71, 20);
            this.txtInputName.TabIndex = 10;
            this.txtInputName.TextChanged += new System.EventHandler(this.txtInputName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Binary Inputs:";
            // 
            // listBoxInputs
            // 
            this.listBoxInputs.FormattingEnabled = true;
            this.listBoxInputs.Location = new System.Drawing.Point(86, 13);
            this.listBoxInputs.Name = "listBoxInputs";
            this.listBoxInputs.Size = new System.Drawing.Size(676, 108);
            this.listBoxInputs.TabIndex = 8;
            this.listBoxInputs.SelectedValueChanged += new System.EventHandler(this.listBoxInputs_SelectedValueChanged);
            // 
            // userControlInputs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btRemoveInput);
            this.Controls.Add(this.btAddInput);
            this.Controls.Add(this.txtInputName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxInputs);
            this.Name = "userControlInputs";
            this.Size = new System.Drawing.Size(771, 130);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRemoveInput;
        private System.Windows.Forms.Button btAddInput;
        private System.Windows.Forms.TextBox txtInputName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxInputs;
    }
}
