using System;
using System.Collections.Generic;
using System.Text;
using TorredeHanoi.Models.Core;

namespace TorredeHanoi.Models
{
    public class Log
    {
        public int Indexador { get; set; }

        public int Disk { get; set; }

        public int FromPole { get; set; }

        public int ToPole { get; set; }

        public string Mensagem { get; set; }

        public string Data { get; set; }
    }
}
