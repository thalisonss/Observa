using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Observa.Models;

namespace Observa
{
    public partial class frmConexoes : Form
    {
        public frmConexoes(AppConfig config)
        {
            InitializeComponent();
            _config = config;
        }

        private readonly AppConfig _config;
        private readonly Services.ConfigService _configService = new();
        private BindingList<ConexaoConfig> _conexoes = new();

        private void dgvConexoes_Load(object sender, EventArgs e)
        {
            _config.Conexoes ??= new List<ConexaoConfig>();
            _conexoes = new BindingList<ConexaoConfig>(_config.Conexoes);

            ConfigurarGrid();
            dgvConexoes.DataSource = _conexoes;
        }

        private void ConfigurarGrid()
        {
            dgvConexoes.AutoGenerateColumns = false;
            dgvConexoes.Columns.Clear();

            // 📛 Nome
            dgvConexoes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome",
                Width = 150
            });

            // 🌐 Servidor
            dgvConexoes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Servidor",
                HeaderText = "Servidor",
                Width = 200
            });

            // 🗄️ Banco
            dgvConexoes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Banco",
                HeaderText = "Banco",
                Width = 150
            });

            // 👤 Usuário
            dgvConexoes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Usuario",
                HeaderText = "Usuário",
                Width = 120
            });

            // 🔒 Senha
            dgvConexoes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Senha",
                HeaderText = "Senha",
                Width = 120
            });
        }

        private async void btnTestar_Click(object sender, EventArgs e)
        {
            dgvConexoes.EndEdit();
            BindingContext[_conexoes]?.EndCurrentEdit();

            if (dgvConexoes.CurrentRow == null)
                return;

            var conexao = (ConexaoConfig)dgvConexoes.CurrentRow.DataBoundItem;

            try
            {
                using var conn = new SqlConnection(conexao.ConnectionString);

                await conn.OpenAsync();

                MessageBox.Show("Conexão OK!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            dgvConexoes.EndEdit();
            BindingContext[_conexoes]?.EndCurrentEdit();

            _config.Conexoes = _conexoes.ToList();

            _configService.SalvarConfig(_config);

            MessageBox.Show("Conexões salvas!");
        }
    }

}
