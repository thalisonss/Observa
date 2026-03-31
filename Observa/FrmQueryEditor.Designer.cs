namespace Observa
{
    partial class FrmQueryEditor
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
            txtQuery = new TextBox();
            groupBox1 = new GroupBox();
            btnOK = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtQuery
            // 
            txtQuery.Dock = DockStyle.Fill;
            txtQuery.Location = new Point(3, 18);
            txtQuery.Margin = new Padding(3, 2, 3, 2);
            txtQuery.Multiline = true;
            txtQuery.Name = "txtQuery";
            txtQuery.Size = new Size(666, 275);
            txtQuery.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtQuery);
            groupBox1.Location = new Point(18, 13);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(672, 295);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Query";
            // 
            // btnOK
            // 
            btnOK.Location = new Point(318, 315);
            btnOK.Margin = new Padding(3, 2, 3, 2);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(82, 22);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // FrmQueryEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btnOK);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmQueryEditor";
            Text = "FrmQueryEditor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtQuery;
        private GroupBox groupBox1;
        private Button btnOK;
    }
}