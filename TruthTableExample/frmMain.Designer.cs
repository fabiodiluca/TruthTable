namespace TruthTableExample
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btWriteTable = new System.Windows.Forms.Button();
            this.userControlInputs1 = new TruthTableExample.userControlInputs();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.examplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExamplesAnd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExamplesOr = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExamplesComplex = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 187);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(753, 280);
            this.textBox1.TabIndex = 0;
            // 
            // txtExpression
            // 
            this.txtExpression.Location = new System.Drawing.Point(89, 161);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(576, 20);
            this.txtExpression.TabIndex = 1;
            this.txtExpression.Text = "A AND B";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expression:";
            // 
            // btWriteTable
            // 
            this.btWriteTable.Location = new System.Drawing.Point(671, 159);
            this.btWriteTable.Name = "btWriteTable";
            this.btWriteTable.Size = new System.Drawing.Size(94, 23);
            this.btWriteTable.TabIndex = 4;
            this.btWriteTable.Text = "Truth Table";
            this.btWriteTable.UseVisualStyleBackColor = true;
            this.btWriteTable.Click += new System.EventHandler(this.btWriteTable_Click);
            // 
            // userControlInputs1
            // 
            this.userControlInputs1.Location = new System.Drawing.Point(3, 30);
            this.userControlInputs1.Name = "userControlInputs1";
            this.userControlInputs1.Size = new System.Drawing.Size(771, 130);
            this.userControlInputs1.TabIndex = 3;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.examplesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(783, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // examplesToolStripMenuItem
            // 
            this.examplesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemExamplesAnd,
            this.menuItemExamplesOr,
            this.menuItemExamplesComplex});
            this.examplesToolStripMenuItem.Name = "examplesToolStripMenuItem";
            this.examplesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.examplesToolStripMenuItem.Text = "Examples";
            // 
            // menuItemExamplesAnd
            // 
            this.menuItemExamplesAnd.Name = "menuItemExamplesAnd";
            this.menuItemExamplesAnd.Size = new System.Drawing.Size(128, 22);
            this.menuItemExamplesAnd.Text = "AND";
            this.menuItemExamplesAnd.Click += new System.EventHandler(this.menuItemExamplesAnd_Click);
            // 
            // menuItemExamplesOr
            // 
            this.menuItemExamplesOr.Name = "menuItemExamplesOr";
            this.menuItemExamplesOr.Size = new System.Drawing.Size(128, 22);
            this.menuItemExamplesOr.Text = "OR";
            this.menuItemExamplesOr.Click += new System.EventHandler(this.menuItemExamplesOr_Click);
            // 
            // menuItemExamplesComplex
            // 
            this.menuItemExamplesComplex.Name = "menuItemExamplesComplex";
            this.menuItemExamplesComplex.Size = new System.Drawing.Size(128, 22);
            this.menuItemExamplesComplex.Text = "COMPLEX";
            this.menuItemExamplesComplex.Click += new System.EventHandler(this.menuItemExamplesComplex_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 476);
            this.Controls.Add(this.btWriteTable);
            this.Controls.Add(this.userControlInputs1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExpression);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "Truth Table";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.Label label1;
        private userControlInputs userControlInputs1;
        private System.Windows.Forms.Button btWriteTable;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem examplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemExamplesAnd;
        private System.Windows.Forms.ToolStripMenuItem menuItemExamplesOr;
        private System.Windows.Forms.ToolStripMenuItem menuItemExamplesComplex;
    }
}

