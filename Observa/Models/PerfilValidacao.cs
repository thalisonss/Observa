using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observa.Models
{
    public class PerfilValidacao
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public List<Validacao> Validacoes { get; set; } = new();
    }
}
