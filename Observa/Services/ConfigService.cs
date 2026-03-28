using Observa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Observa.Services
{
    public class ConfigService
    {
        private readonly string _path = "config.json";

        public AppConfig CarregarConfig()
        {
            if (!File.Exists(_path))
                return new AppConfig();

            var json = File.ReadAllText(_path);
            return JsonSerializer.Deserialize<AppConfig>(json);
        }

        public void SalvarConfig(AppConfig config)
        {
            var json = JsonSerializer.Serialize(config, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(_path, json);
        }
    }
}
