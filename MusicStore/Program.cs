using System;

namespace MusicStore
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            
            MusicStore _musicStore = new MusicStore();
            do
            {
                Console.WriteLine("1.-Registrar Instrumento");
                Console.WriteLine("2.-Registrar Reparacion");
                Console.WriteLine("3.-Mostrar Instrumentos");
                Console.WriteLine("4.-Mostrar Reparaciones");
                Console.WriteLine("0.-Salir");
                Console.WriteLine("Ingrese una opcion:");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        _musicStore.CreateInstrument();
                        break;
                    case 2:
                        _musicStore.CreateAReparation();
                        break;

                    case 3:
                        _musicStore.ShowInstruments();
                        break;

                    case 4:
                        _musicStore.ShowReparations();
                        break;
                    default:
                        break;
                }

            } while (option != 0);
            
        }
    }
}
