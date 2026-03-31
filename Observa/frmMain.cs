#region |Using|
using Observa.Models;
using System.ComponentModel;
using Observa.Services;
#endregion

namespace Observa
{
    public partial class frmMain : Form
    {
        #region |Variáveis|
        private BindingList<MonitorItem> _itens = new();

        private readonly ConfigService _configService = new();
        private readonly MonitorService _monitorService = new();

        
        private AppConfig _config = new();
        #endregion

        public frmMain()
        {
            InitializeComponent();
        }

        #region |Controles|

        private void Form1_Load(object sender, EventArgs e)
        {
            _config = _configService.CarregarConfig();

            _itens = new BindingList<MonitorItem>(_config.ItensMonitor);

            ConfigurarGrid();
            dgvMonitor.DataSource = _itens;
        }

        private async void btnExecutar_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;

            try
            {
                await _monitorService.ExecutarMonitoramentoAsync(_config);
                dgvMonitor.Refresh();
            }
            finally
            {
                btnRefresh.Enabled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _config.ItensMonitor = _itens.ToList();

            _configService.SalvarConfig(_config);

            MessageBox.Show("Configuração salva!");
        }

        private void dgvMonitor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMonitor.Columns[e.ColumnIndex].DataPropertyName == "Status")
            {
                var valor = e.Value?.ToString();

                if (valor == "Verde")
                    e.CellStyle.BackColor = Color.LightGreen;

                else if (valor == "Vermelho")
                    e.CellStyle.BackColor = Color.LightCoral;

                else if (valor == "Amarelo")
                    e.CellStyle.BackColor = Color.Khaki;
            }
        }

        private void dgvMonitor_DefaultValuesNeeded_1(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["Status"].Value = "Pendente";
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            var form = new frmValidacoes(_config);
            form.ShowDialog();


        }

        private void btnConexoes_Click(object sender, EventArgs e)
        {
            var form = new frmConexoes(_config);
            form.ShowDialog();
        }

        #endregion

        #region |Funcoes|
        private void ConfigurarGrid()
        {
            dgvMonitor.AutoGenerateColumns = false;
            dgvMonitor.Columns.Clear();

            // 📌 Descrição
            dgvMonitor.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Descricao",
                HeaderText = "Descrição",
                Width = 200
            });

            // 📌 Chaves
            dgvMonitor.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Chaves",
                HeaderText = "Chaves",
                Width = 200
            });

            // 📌 Perfil (ComboBox)
            var colPerfil = new DataGridViewComboBoxColumn
            {
                HeaderText = "Perfil",
                DataPropertyName = "PerfilId",
                DisplayMember = "Nome",
                ValueMember = "Id",
                DataSource = _config.Perfis,
                Width = 150
            };

            dgvMonitor.Columns.Add(colPerfil);

            // 📌 Status
            dgvMonitor.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                DataPropertyName = "Status",
                HeaderText = "Status",
                ReadOnly = true,
                Width = 100
            });

            // 📌 Mensagem
            dgvMonitor.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Mensagem",
                HeaderText = "Mensagem",
                ReadOnly = true,
                Width = 300
            });

            // 📌 Última Verificação
            dgvMonitor.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UltimaVerificacao",
                HeaderText = "Última Verificação",
                ReadOnly = true,
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "dd/MM/yyyy HH:mm:ss"
                }
            });

            dgvMonitor.DataError += (s, e) => { e.ThrowException = false; };
            dgvMonitor.AllowUserToAddRows = true;
        }

        #endregion       
    }
}
