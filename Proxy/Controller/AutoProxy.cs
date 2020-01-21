using Proxy.Proxy.Controller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Proxy.Controller
{
    public class AutoProxy : IAuto
    {
        private readonly IAuto Auto;
        public readonly ILlave Llave;
        public AutoProxy(IAuto _coche, ILlave _Llave)
        {
            this.Auto = _coche ?? throw new ArgumentNullException(nameof(_coche));
            this.Llave = _Llave ?? throw new ArgumentNullException(nameof(_Llave));
        }
        public bool EncenderAuto()
        {
            bool lEncendido = false;
            if (Llave.cLlave == "449955")
            {
                lEncendido = Auto.EncenderAuto();
            }
            return lEncendido;
        }
    }
}
