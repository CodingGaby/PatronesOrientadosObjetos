using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesOO
{
    class CInternacional:IEnvio
    {
        public double obtenerCosto(double total)
        {
            return total + 200;
        }
    }
}
