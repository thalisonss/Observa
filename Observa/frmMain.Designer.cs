namespace Observa
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvMonitor = new DataGridView();
            btnRefresh = new Button();
            btnSalvar = new Button();
            btnPerfil = new Button();
            btnConexoes = new Button();
            gboPerfil = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvMonitor).BeginInit();
            gboPerfil.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMonitor
            // 
            dgvMonitor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonitor.Location = new Point(6, 26);
            dgvMonitor.Name = "dgvMonitor";
            dgvMonitor.RowHeadersWidth = 51;
            dgvMonitor.Size = new Size(1362, 524);
            dgvMonitor.TabIndex = 0;
            dgvMonitor.CellFormatting += dgvMonitor_CellFormatting;
            dgvMonitor.DefaultValuesNeeded += dgvMonitor_DefaultValuesNeeded_1;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(1262, 26);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Atualizar";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnExecutar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(1279, 26);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(77, 29);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnPerfil
            // 
            btnPerfil.Location = new Point(898, 26);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(186, 29);
            btnPerfil.TabIndex = 3;
            btnPerfil.Text = "Configurar Validações";
            btnPerfil.UseVisualStyleBackColor = true;
            btnPerfil.Click += btnPerfil_Click;
            // 
            // btnConexoes
            // 
            btnConexoes.Location = new Point(1090, 26);
            btnConexoes.Name = "btnConexoes";
            btnConexoes.Size = new Size(183, 29);
            btnConexoes.TabIndex = 4;
            btnConexoes.Text = "Configurar Conexões";
            btnConexoes.UseVisualStyleBackColor = true;
            btnConexoes.Click += btnConexoes_Click;
            // 
            // gboPerfil
            // 
            gboPerfil.Controls.Add(btnSalvar);
            gboPerfil.Controls.Add(btnPerfil);
            gboPerfil.Controls.Add(btnConexoes);
            gboPerfil.Location = new Point(12, 12);
            gboPerfil.Name = "gboPerfil";
            gboPerfil.Size = new Size(1374, 82);
            gboPerfil.TabIndex = 5;
            gboPerfil.TabStop = false;
            gboPerfil.Text = "Perfil";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvMonitor);
            groupBox2.Location = new Point(12, 171);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1374, 556);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Monitoramentos";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnRefresh);
            groupBox3.Location = new Point(12, 100);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1374, 65);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Monitoria";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 739);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(gboPerfil);
            Name = "frmMain";
            Text = "Observa | Dashboard";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMonitor).EndInit();
            gboPerfil.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMonitor;
        private Button btnRefresh;
        private Button btnSalvar;
        private Button btnPerfil;
        private Button btnConexoes;
        private GroupBox gboPerfil;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
