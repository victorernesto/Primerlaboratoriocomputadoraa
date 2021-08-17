using computadora.Entidades;
using computadora.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Clscomputadora clscomputadora = new Clscomputadora();
            NClscomputadora nclscomputadora = new NClscomputadora();

            clscomputadora.MemoriaRam = 8;
            clscomputadora.Procesador = "intel core !5 dual";

            Console.WriteLine(nclscomputadora.Encendiendo(clscomputadora));


            Console.ReadLine();
        }
    }
}
