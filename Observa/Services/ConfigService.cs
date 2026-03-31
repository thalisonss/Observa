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
        private readonly string _path;

        public ConfigService(string? path = null)
        {
            _path = path ?? Path.Combine(AppContext.BaseDirectory, "config.json");
        }

        public AppConfig CarregarConfig()
        {
            if (!File.Exists(_path))
                return new AppConfig();

            var json = File.ReadAllText(_path);
            return JsonSerializer.Deserialize<AppConfig>(json) ?? new AppConfig();
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
