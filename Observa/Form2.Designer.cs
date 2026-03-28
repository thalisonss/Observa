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
            ((System.ComponentModel.ISupportInitialize)dgvValidacoes).BeginInit();
            SuspendLayout();
            // 
            // dgvValidacoes
            // 
            dgvValidacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvValidacoes.Location = new Point(79, 102);
            dgvValidacoes.Name = "dgvValidacoes";
            dgvValidacoes.RowHeadersWidth = 51;
            dgvValidacoes.Size = new Size(1095, 482);
            dgvValidacoes.TabIndex = 1;
            dgvValidacoes.CellContentClick += dgvValidacoes_CellContentClick;
            // 
            // cbPerfis
            // 
            cbPerfis.FormattingEnabled = true;
            cbPerfis.Location = new Point(104, 35);
            cbPerfis.Name = "cbPerfis";
            cbPerfis.Size = new Size(151, 28);
            cbPerfis.TabIndex = 2;
            cbPerfis.SelectedIndexChanged += cbPerfis_SelectedIndexChanged;
            // 
            // btnNovoPerfil
            // 
            btnNovoPerfil.Location = new Point(672, 39);
            btnNovoPerfil.Name = "btnNovoPerfil";
            btnNovoPerfil.Size = new Size(94, 29);
            btnNovoPerfil.TabIndex = 3;
            btnNovoPerfil.Text = "button1";
            btnNovoPerfil.UseVisualStyleBackColor = true;
            btnNovoPerfil.Click += btnNovoPerfil_Click;
            // 
            // btnExcluirPerfil
            // 
            btnExcluirPerfil.Location = new Point(826, 39);
            btnExcluirPerfil.Name = "btnExcluirPerfil";
            btnExcluirPerfil.Size = new Size(94, 29);
            btnExcluirPerfil.TabIndex = 4;
            btnExcluirPerfil.Text = "button1";
            btnExcluirPerfil.UseVisualStyleBackColor = true;
            btnExcluirPerfil.Click += btnExcluirPerfil_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(1050, 607);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "button1";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // frmValidacoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 686);
            Controls.Add(btnSalvar);
            Controls.Add(btnExcluirPerfil);
            Controls.Add(btnNovoPerfil);
            Controls.Add(cbPerfis);
            Controls.Add(dgvValidacoes);
            Name = "frmValidacoes";
            Text = "Form2";
            Load += frmValidacoes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvValidacoes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvValidacoes;
        private ComboBox cbPerfis;
        private Button btnNovoPerfil;
        private Button btnExcluirPerfil;
        private Button btnSalvar;
    }
}