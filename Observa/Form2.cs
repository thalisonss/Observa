using Observa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observa
{
    public partial class frmValidacoes : Form
    {
        private AppConfig _config;
        private BindingList<Validacao> _validacoes;
        private PerfilValidacao _perfilAtual;
  

      
        public frmValidacoes (AppConfig config)
        {
            InitializeComponent();
            _config = config;
            CarregarPerfis();
        }

        private void CarregarPerfis()
        {
            cbPerfis.DataSource = null;

            cbPerfis.DataSource = _config.Perfis;
            cbPerfis.DisplayMember = "Nome";
            cbPerfis.ValueMember = "Id";
        }

        private void cbPerfis_SelectedIndexChanged(object sender, EventArgs e)
        {
            _perfilAtual = cbPerfis.SelectedItem as PerfilValidacao;
            if (_perfilAtual == null)
            {
                _validacoes = new BindingList<Validacao>();
                dgvValidacoes.DataSource = _validacoes;
                return;
            }

            _perfilAtual.Validacoes ??= new List<Validacao>();

            _validacoes = new BindingList<Validacao>(_perfilAtual.Validacoes);

            ConfigurarGrid();
            dgvValidacoes.DataSource = _validacoes;
        }

        private void ConfigurarGrid()
        {
            dgvValidacoes.AutoGenerateColumns = false;
            dgvValidacoes.Columns.Clear();

            // 🔢 Sequência
            dgvValidacoes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Sequencia",
                HeaderText = "Seq",
                Width = 50
            });

            // 📛 Nome
            dgvValidacoes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nome",
                HeaderText = "Nome da Validação",
                Width = 200
            });

            // ✅ Mensagem Sucesso
            dgvValidacoes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MensagemSucesso",
                HeaderText = "Mensagem Sucesso",
                Width = 200
            });

            // ❌ Mensagem Erro
            dgvValidacoes.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "MensagemErro",
                HeaderText = "Mensagem Erro",
                Width = 200
            });

            // 🎯 Regra (ComboBox)
            var colRegra = new DataGridViewComboBoxColumn
            {
                HeaderText = "Sucesso Se",
                DataPropertyName = "SucessoSe",
                DataSource = Enum.GetValues(typeof(TipoRetorno)),
                Width = 150
            };
            dgvValidacoes.Columns.Add(colRegra);

            // 🔌 Conexão (ComboBox)
            var colConexao = new DataGridViewComboBoxColumn
            {
                HeaderText = "Conexão",
                DataPropertyName = "Conexao",
                DataSource = _config.Conexoes,
                DisplayMember = "Nome",
                ValueMember = "Nome",
                Width = 150
            };
            dgvValidacoes.Columns.Add(colConexao);

            // 🧠 Query (Botão)
            var colQuery = new DataGridViewButtonColumn
            {
                HeaderText = "Query",
                Text = "Editar",
                UseColumnTextForButtonValue = true,
                Width = 80
            };
            dgvValidacoes.Columns.Add(colQuery);
        }

        private void dgvValidacoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;


            if (dgvValidacoes.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                var validacao = _validacoes[e.RowIndex];

                var form = new FrmQueryEditor(validacao.Query);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    validacao.Query = form.Query;
                }
            }
        }

       

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _perfilAtual.Validacoes = _validacoes.ToList();

            File.WriteAllText("config.json",
                JsonSerializer.Serialize(_config, new JsonSerializerOptions
                {
                    WriteIndented = true
                }));

            MessageBox.Show("Perfil salvo!");
        }

        private void btnNovoPerfil_Click(object sender, EventArgs e)
        {
            var perfil = new PerfilValidacao
            {
                Id = _config.Perfis.Any() ? _config.Perfis.Max(p => p.Id) + 1 : 1,
                Nome = "Novo Perfil"
            };

            _config.Perfis.Add(perfil);

            CarregarPerfis();
            cbPerfis.SelectedItem = perfil;

        }

        private void btnExcluirPerfil_Click(object sender, EventArgs e)
        {
            if (_perfilAtual == null) return;

            _config.Perfis.Remove(_perfilAtual);

            CarregarPerfis();
        }

        private void frmValidacoes_Load(object sender, EventArgs e)
        {
           ConfigurarGrid();
        }
    }
}
