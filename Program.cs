using Proxy.Proxy.Controller;
using Proxy.Proxy.Controller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Init();
        }

        private static void Init()
        {
            IAuto entAuto = new Auto();
            ILlave entLlave = new Llave();
            IAuto CocheProxy = new AutoProxy(entAuto, entLlave);
            string cLlave = string.Empty;
            do
            {
                Console.Write("Capturar el codigo de la llave:\n");
                cLlave = Console.ReadLine();
                entLlave.cLlave = cLlave;
                if (!CocheProxy.EncenderAuto())
                    Console.WriteLine("Llave Incorrecta.");
            }
            while (cLlave != "449955");

            Console.ReadLine();
        }
    }
}
