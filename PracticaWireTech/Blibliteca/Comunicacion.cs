using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
     public class Comunicacion
    {
      public zonas zonaC { get; set; }
      
        public void descuentos()
        {
            switch (zonaC)
            {
                case zonas.def:
                    break;
                case zonas.cuyo:
                    break;
                case zonas.norte:
                    break;
                default:
                    break;
            }
        }
    }
}
