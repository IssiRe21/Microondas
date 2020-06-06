using System;
using System.Collections.Generic;

namespace Microondas
{
    class Menu
    {
        private const int MAIN_MENU_EXIT_OPTION = 9;
        List<int> mainMenuOptions = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 9 });
        public List<int> seleccionarComidaOContenedor = new List<int>(new int[] { 1, 2, 3 });
        public Contenedor contenedorUsado = null;
        public Comida comidaUsada = null;

        Microondas microondas = new Microondas();


        private void DisplayWelcomeMessage()
        {
            System.Console.WriteLine("¿Qué es lo que queres hacer?");
            System.Console.WriteLine();
        }

        private void DisplayMainMenuOptions()
        {
            System.Console.WriteLine("1) Abrir puerta");
            System.Console.WriteLine("2) Cerrar puerta");
            System.Console.WriteLine("3) Elegir comida");
            System.Console.WriteLine("4) Elegir contenedor");
            System.Console.WriteLine("5) Introducir comida al microondas");
            System.Console.WriteLine("6) Calentar comida");
            System.Console.WriteLine();
            System.Console.WriteLine("9) Salir");
        }

        private void DisplayByeMessage()
        {
            System.Console.WriteLine("Te alejaste del microondas");
        }

        public int RequestOption(List<int> validOptions)
        {
            int userInputAsInt = 0;
            bool isUserInputValid = false;

            while (!isUserInputValid)
            {
                System.Console.WriteLine("Selecciona una opción:");
                string userInput = System.Console.ReadLine();


                try
                {
                    userInputAsInt = Convert.ToInt32(userInput);
                    isUserInputValid = validOptions.Contains(userInputAsInt);
                }
                catch (System.Exception)
                {
                    isUserInputValid = false;
                }


                if (!isUserInputValid)
                {
                    System.Console.WriteLine("La opción seleccionada no es válida.");
                }
            }

            return userInputAsInt;
        }

        private void OpcionesComida()
        {
            System.Console.WriteLine("Seleciona la comida que quieres calentar");
            System.Console.WriteLine("1) Hamburguesa");
            System.Console.WriteLine("2) Carne");
            System.Console.WriteLine("3) Pizza");

        }

        public void ElegirComida()
        {
            int selectedOption = 0;


            OpcionesComida();

            selectedOption = Menu.RequestOption(seleccionarComidaOContenedor);

            switch (selectedOption)
            {
                case 1:
                    comidaUsada = new Comida("Hamburguesa");
                    break;
                case 2:
                    comidaUsada = new Comida("Carne");
                    break;
                case 3:
                    comidaUsada = new Comida("Pizza");
                    break;

            }
            System.Console.WriteLine($"Comida seleccionada: {comidaUsada}");
        }

        private void OpcionesContenedor()
        {
            System.Console.WriteLine("Seleciona el contenedor para calentar la comida");
            System.Console.WriteLine("1) Plato de Vidrio");
            System.Console.WriteLine("2) Plato de Metal");
            System.Console.WriteLine("3) Plato de plastico");

        }

        public void Elegircontenedor()
        {
            int selectedOption = 0;

            OpcionesContenedor();

            selectedOption = RequestOption(seleccionarComidaOContenedor);

            switch (selectedOption)
            {
                case 1:
                    contenedorUsado = new Contenedor("Plato de Vidrio", true);
                    break;
                case 2:
                    contenedorUsado = new Contenedor("Plato de metal", false);
                    break;
                case 3:
                    contenedorUsado = new Contenedor("Plato de plastico", true);
                    break;

            }
        }





        public void Display()
        {
            int selectedOption = 0;

            DisplayWelcomeMessage();

            while (selectedOption != MAIN_MENU_EXIT_OPTION)
            {
                DisplayMainMenuOptions();

                selectedOption = RequestOption(mainMenuOptions);

                switch (selectedOption)
                {
                    case 1:
                        microondas.AbrirPuerta();
                        break;

                    case 2:
                        microondas.CerrarPuerta();
                        break;

                    case 3:
                        ElegirComida();
                        break;

                    case 4:
                        Elegircontenedor();
                        break;

                    case 5:
                        microondas.IntroducirAlimento(contenedorUsado, comidaUsada);
                        break;

                    case 6:
                        microondas.CalentarComida();
                        break;

                }
            }

            DisplayByeMessage();

        }
    }
}

