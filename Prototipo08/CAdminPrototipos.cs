using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo08
{
    class CAdminPrototipos
    {
        private Dictionary<string, IPrototipo> prototipos = new Dictionary<string, IPrototipo>();

        public CAdminPrototipos()
        {
            // Adicionamos los objetos prototipo con los valores iniciales que nos interesan

            CPersona persona = new CPersona("Cuidadano", 18);
            prototipos.Add("Persona", persona);

            CValores valores = new CValores(1);
            prototipos.Add("Valores", valores);
        }

        public void AdicionaPrototipo(string pLlave, IPrototipo pPrototipo)
        {
            prototipos.Add(pLlave, pPrototipo);
        }

        public object ObtenerPrototipo(string pLlave)
        {
            return prototipos[pLlave].Clonar();
        }
    }
}
