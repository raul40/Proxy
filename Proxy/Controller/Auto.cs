using Proxy.Proxy.Controller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Proxy.Controller
{
    public class Auto : IAuto
    {
        public bool EncenderAuto()
        {
            Console.WriteLine("Automovil Encendido");
            return true;
        }
    }
}
