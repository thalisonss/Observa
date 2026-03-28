using Microsoft.Data.SqlClient;
using Observa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observa.Services
{

    public class MonitorService
    {
        public void ExecutarMonitoramento(AppConfig config)
        {
            foreach (var item in config.ItensMonitor)
            {
                var conexao = config.Conexoes
                    .FirstOrDefault(c => c.Nome == item.Conexao);

                var perfil = config.Perfis
                    .FirstOrDefault(p => p.Nome == item.Perfil);

                if (conexao == null || perfil == null)
                    continue;

                using var conn = new SqlConnection(conexao.ConnectionString);
                conn.Open();

                foreach (var validacao in perfil.Validacoes)
                {
                    using var cmd = new SqlCommand(validacao.Query, conn);
                    using var reader = cmd.ExecuteReader();

                    bool temDados = reader.HasRows;

                    bool ok = validacao.TipoRetorno == TipoRetorno.RetornarDados
                        ? temDados
                        : !temDados;

                    validacao.StatusOK = ok;
                    validacao.Cor = ok ? "Verde" : "Vermelho";

                    if (!ok)
                        break; // PARA A EXECUÇÃO
                }
            }
        }
    }
}
