using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsupConfig.Core.Models
{
    public class Localidade : BaseEntity
    {
        public string Designacao { get; set; }
        public string SubRede { get; set; }

        public virtual Servidor Servidor { get; set; }
    }
}
