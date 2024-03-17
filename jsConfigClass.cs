using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractce_CopyingClassFramework
{
    public class jsConfigClass
    {
        IConfigurationRoot configRoot;
        public jsConfigClass()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("jsFile.json");
            configRoot = builder.Build();
        }

        public string GetJsonData(string key) => configRoot[key]!;
    }
}
