using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observa.Models
{
    public class ConexaoConfig
    {
        private string _connectionStringLegada;
        public string Nome { get; set; }
        public string Servidor { get; set; }
        public string Banco { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public string ConnectionString
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Servidor)
                    && string.IsNullOrWhiteSpace(Banco)
                    && string.IsNullOrWhiteSpace(Usuario)
                    && string.IsNullOrWhiteSpace(Senha))
                {
                    return _connectionStringLegada;
                }

                var builder = new SqlConnectionStringBuilder
                {
                    DataSource = Servidor ?? string.Empty,
                    InitialCatalog = Banco ?? string.Empty,
                    TrustServerCertificate = true
                };

                var usarAutenticacaoSql =
                    !string.IsNullOrWhiteSpace(Usuario) || !string.IsNullOrWhiteSpace(Senha);

                if (usarAutenticacaoSql)
                {
                    builder.UserID = Usuario ?? string.Empty;
                    builder.Password = Senha ?? string.Empty;
                    builder.IntegratedSecurity = false;
                }
                else
                {
                    builder.IntegratedSecurity = true;
                }

                return builder.ConnectionString;
            }
            set
            {
                _connectionStringLegada = value;

                if (!string.IsNullOrWhiteSpace(Servidor)
                    || !string.IsNullOrWhiteSpace(Banco)
                    || !string.IsNullOrWhiteSpace(Usuario)
                    || !string.IsNullOrWhiteSpace(Senha)
                    || string.IsNullOrWhiteSpace(value))
                {
                    return;
                }

                try
                {
                    var builder = new SqlConnectionStringBuilder(value);
                    Servidor = builder.DataSource;
                    Banco = builder.InitialCatalog;
                    Usuario = builder.IntegratedSecurity ? string.Empty : builder.UserID;
                    Senha = builder.IntegratedSecurity ? string.Empty : builder.Password;
                }
                catch
                {
                    // Mantém apenas a connection string legada quando não for possível interpretar.
                }
            }
        }
    }
}
