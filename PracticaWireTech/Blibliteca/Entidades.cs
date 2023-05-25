using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
     public abstract class Entidades
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string descrip { get; set; }
        public int CodProv { get; set; }

    }
}
