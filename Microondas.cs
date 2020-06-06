using System;

namespace Microondas
{
    class Microondas
    {
        private bool puertaEstaAbierta = false;
        Contenedor contenedorAdentro = null;




        public void AbrirPuerta()
        {
            if (puertaEstaAbierta == false)
            {
                puertaEstaAbierta = true;
                System.Console.WriteLine("Abriste la puerta");
            }
            else
            {
                System.Console.WriteLine("La puerta ya esta abierta");
            }
        }

        public void IntroducirAlimento(Contenedor contenedor, Comida comida)
        {
            if (contenedorAdentro != null)
            {
                throw new InvalidOperationException("Ya hay algo adentro del microondas");
                return;
            }
            else
            {
                if (contenedor == null)
                {
                    throw new InvalidOperationException("No hay ningun contenedor");
                    return;
                }
                else
                {
                    if (comida == null)
                    {
                        throw new InvalidOperationException("No hay ninguna comida");
                        return;
                    }

                }
            }
            System.Console.WriteLine($"Se introdujo un {contenedor.Tomarnombre} con {comida.Tomarnombre}");
            contenedorAdentro = contenedor;
        }

        public void CerrarPuerta()
        {
            if (puertaEstaAbierta == true)
            {
                puertaEstaAbierta = false;
                System.Console.WriteLine("Cerraste la puerta");
            }
            else
            {
                System.Console.WriteLine("La puerta ya esta cerrada");
            }
        }
        public void CalentarComida()
        {

        }


    }
}
