using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Observa.Models
{
    public class MonitorItem
    {
        public string Descricao { get; set; }
        public string Chaves { get; set; }
        public int? PerfilId { get; set; }
        public string Conexao { get; set; }
        public string Perfil { get; set; }

        [JsonIgnore]
        public string Nome
        {
            get => Descricao;
            set => Descricao = value;
        }
    }
}
