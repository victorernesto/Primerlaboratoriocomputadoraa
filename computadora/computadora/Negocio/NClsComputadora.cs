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
       
        public String pantalla(Clscomputadora computadora)
        {
            return " cuenta con una pantalla de" + computadora.Pantalla;
        }

        public String Espacio(Clscomputadora computadora)
        { 
            return " cuenta con un almacenamiento de" + computadora.Almacenamiento;
        }

        public String Graficos(Clscomputadora computadora)
        {
            return "cuenta con graficos " + computadora.Grafica;
        }

        public String Encendiendo(Clscomputadora computadora)
        {
            return " la computadora con memoria ran de " + computadora.MemoriaRam + "gb y micro procesadora " + computadora.Procesador + " esta encendida ";
        }

    }
} 
