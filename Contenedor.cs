using System;

namespace Microondas
{
    class Contenedor
    {
        public string nombreContenedor { get; set; }
        public bool contenedorApto { get; set; }

        public Contenedor(string nombreContenedor, bool contenedorApto)
        {
            this.nombreContenedor = nombreContenedor;
            this.contenedorApto = contenedorApto;
        }

        public string Tomarnombre()
        {
            return nombreContenedor;
        }
         public bool VerSiEsApto()
        {
            return contenedorApto;
        }
    }
}
