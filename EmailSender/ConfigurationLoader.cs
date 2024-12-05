using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSender
{
    public static class ConfigurationLoader
    {
        public static IConfiguration Load()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("JSON.json", optional: true, reloadOnChange: true); 

            return builder.Build();
        }
    }
}
