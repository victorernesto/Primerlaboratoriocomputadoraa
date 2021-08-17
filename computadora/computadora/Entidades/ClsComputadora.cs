using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace computadora.Entidades
{
    class Clscomputadora
    {
        private int dimenciones;
        private int memoriaRam;
        private String procesador;
        private String mous;
        private String grafica;
        private String nombre;
        private String resolucion;
        private String sistemaoperativo;
        private String pantalla;
        private String almacenamiento;

        public int Dimenciones { get => dimenciones; set => dimenciones = value; }
        public int MemoriaRam { get => memoriaRam; set => memoriaRam = value; }
        public string Procesador { get => procesador; set => procesador = value; }
        public string Mous { get => mous; set => mous = value; }
        public string Grafica { get => grafica; set => grafica = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Resolucion { get => resolucion; set => resolucion = value; }
        public string Sistemaoperativo { get => sistemaoperativo; set => sistemaoperativo = value; }
        public string Pantalla { get => pantalla; set => pantalla = value; }
        public string Almacenamiento { get => almacenamiento; set => almacenamiento = value; }
    }
}
