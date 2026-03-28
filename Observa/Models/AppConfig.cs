using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observa.Models
{
    public class AppConfig
    {
        public List<ConexaoConfig> Conexoes { get; set; } = new();

        public List<PerfilValidacao> Perfis { get; set; } = new();

        public List<MonitorItem> ItensMonitor { get; set; } = new();
    }
}
