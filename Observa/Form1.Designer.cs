namespace Observa
{
    partial class Form1
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
            btnExecutar = new Button();
            btnSalvar = new Button();
            btnPerfil = new Button();
            btnConexoes = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMonitor).BeginInit();
            SuspendLayout();
            // 
            // dgvMonitor
            // 
            dgvMonitor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMonitor.Location = new Point(125, 149);
            dgvMonitor.Name = "dgvMonitor";
            dgvMonitor.RowHeadersWidth = 51;
            dgvMonitor.Size = new Size(1095, 482);
            dgvMonitor.TabIndex = 0;
            dgvMonitor.CellFormatting += dgvMonitor_CellFormatting;
            dgvMonitor.DefaultValuesNeeded += dgvMonitor_DefaultValuesNeeded_1;
            // 
            // btnExecutar
            // 
            btnExecutar.Location = new Point(880, 65);
            btnExecutar.Name = "btnExecutar";
            btnExecutar.Size = new Size(94, 29);
            btnExecutar.TabIndex = 1;
            btnExecutar.Text = "button1";
            btnExecutar.UseVisualStyleBackColor = true;
            btnExecutar.Click += btnExecutar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(1000, 65);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "button2";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnPerfil
            // 
            btnPerfil.Location = new Point(1273, 220);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(94, 29);
            btnPerfil.TabIndex = 3;
            btnPerfil.Text = "button1";
            btnPerfil.UseVisualStyleBackColor = true;
            btnPerfil.Click += btnPerfil_Click;
            // 
            // btnConexoes
            // 
            btnConexoes.Location = new Point(1282, 333);
            btnConexoes.Name = "btnConexoes";
            btnConexoes.Size = new Size(94, 29);
            btnConexoes.TabIndex = 4;
            btnConexoes.Text = "button1";
            btnConexoes.UseVisualStyleBackColor = true;
            btnConexoes.Click += btnConexoes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1398, 709);
            Controls.Add(btnConexoes);
            Controls.Add(btnPerfil);
            Controls.Add(btnSalvar);
            Controls.Add(btnExecutar);
            Controls.Add(dgvMonitor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMonitor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMonitor;
        private Button btnExecutar;
        private Button btnSalvar;
        private Button btnPerfil;
        private Button btnConexoes;
    }
}
