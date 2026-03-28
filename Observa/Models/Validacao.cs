using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observa.Models
{
    public class Validacao
    {
        public string Nome { get; set; }
        public string Query { get; set; }

        public TipoRetorno TipoRetorno { get; set; }

        public bool StatusOK { get; set; }
        public string Cor { get; set; } // Verde / Vermelho
    }
}
