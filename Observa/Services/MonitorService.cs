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
        private static void AdicionarParametros(SqlCommand cmd, string chaves)
        {
            if (string.IsNullOrWhiteSpace(chaves))
                return;

            var itens = chaves
                .Split(new[] { ';', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(v => v.Trim())
                .Where(v => !string.IsNullOrWhiteSpace(v))
                .ToList();

            for (var i = 0; i < itens.Count; i++)
            {
                var item = itens[i];
                var igualIndex = item.IndexOf('=');

                if (igualIndex > 0)
                {
                    var nome = item[..igualIndex].Trim();
                    var valor = item[(igualIndex + 1)..].Trim();

                    if (!nome.StartsWith("@"))
                        nome = $"@{nome}";

                    cmd.Parameters.AddWithValue(nome, valor);
                }
                else
                {
                    cmd.Parameters.AddWithValue($"@p{i + 1}", item);
                }
            }
        }


        public void ExecutarMonitoramento(AppConfig config)
        {

            config.ItensMonitor ??= new List<MonitorItem>();
            config.Perfis ??= new List<PerfilValidacao>();
            config.Conexoes ??= new List<ConexaoConfig>();

            foreach (var item in config.ItensMonitor)
            {
                item.UltimaVerificacao = DateTime.Now;
                item.Status = "Amarelo";
                item.Mensagem = "Executando validações...";
                
                var perfil = config.Perfis
                    .FirstOrDefault(p => p.Id == item.PerfilId)
                    ?? config.Perfis.FirstOrDefault(p => p.Nome == item.Perfil);

                if (perfil == null)
                {
                    item.Status = "Vermelho";
                    item.Mensagem = "Perfil de validação não encontrado.";
                    continue;
                }

                perfil.Validacoes ??= new List<Validacao>();

                if (perfil.Validacoes.Count == 0)
                {
                    item.Status = "Vermelho";
                    item.Mensagem = "Perfil sem validações configuradas.";
                    continue;
                }

                var todasValidacoesOk = true;

                foreach (var validacao in perfil.Validacoes)
                {
                    try
                    {
                        var nomeConexao = !string.IsNullOrWhiteSpace(validacao.Conexao)
                            ? validacao.Conexao
                            : item.Conexao;

                        var conexao = config.Conexoes
                            .FirstOrDefault(c => c.Nome == nomeConexao);

                        if (conexao == null)
                        {
                            validacao.StatusOK = false;
                            validacao.Cor = "Vermelho";

                            item.Status = "Vermelho";
                            item.Mensagem = $"Conexão '{nomeConexao}' não encontrada.";
                            todasValidacoesOk = false;
                            break;
                        }

                        using var conn = new SqlConnection(conexao.ConnectionString);
                        conn.Open();

                        using var cmd = new SqlCommand(validacao.Query, conn);
                        AdicionarParametros(cmd, item.Chaves);
                        using var reader = cmd.ExecuteReader();

                        bool temDados = reader.HasRows;

                        bool ok = validacao.TipoRetorno == TipoRetorno.RetornarDados
                            ? temDados
                            : !temDados;

                        validacao.StatusOK = ok;
                        validacao.Cor = ok ? "Verde" : "Vermelho";

                        if (ok)
                        {
                            item.Status = "Verde";
                            item.Mensagem = !string.IsNullOrWhiteSpace(validacao.MensagemSucesso)
                                ? validacao.MensagemSucesso
                                : $"Validação '{validacao.Nome}' executada com sucesso.";
                            continue;
                        }

                        item.Status = "Vermelho";
                        item.Mensagem = !string.IsNullOrWhiteSpace(validacao.MensagemErro)
                            ? validacao.MensagemErro
                            : $"Validação '{validacao.Nome}' retornou inconsistência.";

                        todasValidacoesOk = false;
                        break; // PARA A EXECUÇÃO
                    }
                    catch (Exception ex)
                    {
                        validacao.StatusOK = false;
                        validacao.Cor = "Vermelho";

                        item.Status = "Vermelho";
                        item.Mensagem = $"Erro na validação '{validacao.Nome}': {ex.Message}";
                        todasValidacoesOk = false;
                        break; // PARA A EXECUÇÃO
                    }
                }

                if (todasValidacoesOk && string.IsNullOrWhiteSpace(item.Mensagem))
                {
                    item.Status = "Verde";
                    item.Mensagem = "Todas as validações foram executadas com sucesso.";
                }
            }
        }
    }
}
