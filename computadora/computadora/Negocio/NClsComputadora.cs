using computadora.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computadora.Negocio
{
    class NClscomputadora
    {
        public String Encendiendo(Clscomputadora computadora) 
        {
            computadora.MemoriaRam = 8;
            computadora.Procesador = "intel core !5 dual";

            return "la computadora con memoria ran de"+ computadora.MemoriaRam +"gb y micro procesadora"+ computadora.Procesador+"esta encendida";
        }



    }
    
}
   
}
