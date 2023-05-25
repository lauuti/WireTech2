using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Pago
    {
        public int CodigoInc { get; set; }
        public DateTime FechaCobro { get; set; }
        public long DNIpag { get; set; }
        public int CodServ { get; set; }
        public long importe { get; set; }
    }
}
