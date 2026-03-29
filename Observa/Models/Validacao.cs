using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Observa.Models
{
    public class Validacao
    {
        public int Sequencia { get; set; }
        public string Nome { get; set; }
        public string MensagemSucesso { get; set; }
        public string MensagemErro { get; set; }
        public string Conexao { get; set; }
        public string Query { get; set; }
        public TipoRetorno SucessoSe { get; set; }
        [JsonIgnore]
        public TipoRetorno TipoRetorno
        {
            get => SucessoSe;
            set => SucessoSe = value;
        }

        [JsonPropertyName("TipoRetorno")]
        public TipoRetorno TipoRetornoLegado
        {
            set => SucessoSe = value;
        }
        public bool StatusOK { get; set; }
        public string Cor { get; set; } // Verde / Vermelho
    }
}
