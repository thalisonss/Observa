namespace Observa
{
    partial class frmConexoes
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
            dgvConexoes = new DataGridView();
            btnTestar = new Button();
            btnSalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConexoes).BeginInit();
            SuspendLayout();
            // 
            // dgvConexoes
            // 
            dgvConexoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConexoes.Location = new Point(111, 87);
            dgvConexoes.Name = "dgvConexoes";
            dgvConexoes.RowHeadersWidth = 51;
            dgvConexoes.Size = new Size(300, 188);
            dgvConexoes.TabIndex = 0;
            // 
            // btnTestar
            // 
            btnTestar.Location = new Point(366, 363);
            btnTestar.Name = "btnTestar";
            btnTestar.Size = new Size(94, 29);
            btnTestar.TabIndex = 1;
            btnTestar.Text = "button1";
            btnTestar.UseVisualStyleBackColor = true;
            btnTestar.Click += btnTestar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(479, 351);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "button1";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmConexoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(btnTestar);
            Controls.Add(dgvConexoes);
            Name = "frmConexoes";
            Text = "dgvConexoes";
            Load += dgvConexoes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConexoes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvConexoes;
        private Button btnTestar;
        private Button btnSalvar;
    }
}