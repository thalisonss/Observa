namespace Observa
{
    partial class frmValidacoes
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
            dgvValidacoes = new DataGridView();
            cbPerfis = new ComboBox();
            btnNovoPerfil = new Button();
            btnExcluirPerfil = new Button();
            btnSalvar = new Button();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvValidacoes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvValidacoes
            // 
            dgvValidacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvValidacoes.Location = new Point(12, 70);
            dgvValidacoes.Margin = new Padding(3, 2, 3, 2);
            dgvValidacoes.Name = "dgvValidacoes";
            dgvValidacoes.RowHeadersWidth = 51;
            dgvValidacoes.Size = new Size(958, 362);
            dgvValidacoes.TabIndex = 1;
            dgvValidacoes.CellContentClick += dgvValidacoes_CellContentClick;
            // 
            // cbPerfis
            // 
            cbPerfis.FormattingEnabled = true;
            cbPerfis.Location = new Point(24, 21);
            cbPerfis.Margin = new Padding(3, 2, 3, 2);
            cbPerfis.Name = "cbPerfis";
            cbPerfis.Size = new Size(133, 23);
            cbPerfis.TabIndex = 2;
            cbPerfis.SelectedIndexChanged += cbPerfis_SelectedIndexChanged;
            // 
            // btnNovoPerfil
            // 
            btnNovoPerfil.Location = new Point(591, 12);
            btnNovoPerfil.Margin = new Padding(3, 2, 3, 2);
            btnNovoPerfil.Name = "btnNovoPerfil";
            btnNovoPerfil.Size = new Size(82, 22);
            btnNovoPerfil.TabIndex = 3;
            btnNovoPerfil.Text = "button1";
            btnNovoPerfil.UseVisualStyleBackColor = true;
            btnNovoPerfil.Click += btnNovoPerfil_Click;
            // 
            // btnExcluirPerfil
            // 
            btnExcluirPerfil.Location = new Point(705, 12);
            btnExcluirPerfil.Margin = new Padding(3, 2, 3, 2);
            btnExcluirPerfil.Name = "btnExcluirPerfil";
            btnExcluirPerfil.Size = new Size(82, 22);
            btnExcluirPerfil.TabIndex = 4;
            btnExcluirPerfil.Text = "button1";
            btnExcluirPerfil.UseVisualStyleBackColor = true;
            btnExcluirPerfil.Click += btnExcluirPerfil_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(847, 24);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 25);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "button1";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbPerfis);
            groupBox1.Location = new Point(18, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // frmValidacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 484);
            Controls.Add(groupBox1);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluirPerfil);
            Controls.Add(btnNovoPerfil);
            Controls.Add(dgvValidacoes);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmValidacoes";
            Text = "Form2";
            Load += frmValidacoes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvValidacoes).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvValidacoes;
        private ComboBox cbPerfis;
        private Button btnNovoPerfil;
        private Button btnExcluirPerfil;
        private Button btnSalvar;
        private GroupBox groupBox1;
    }
}