using System;

namespace Microondas
{
    class Comida
    {
        public string nombre { get; set;}
        public Comida(string nombre)
        {
            this.nombre = nombre;
        }

        public string Tomarnombre()
        {
            return nombre;
        }
    }
}
