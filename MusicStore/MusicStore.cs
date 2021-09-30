using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore
{
    class MusicStore
    {
        List<Instrument> instrumentsList = new List<Instrument>();
        List<Reparation> reparationsList = new List<Reparation>();
        public void CreateInstrument()
        {
            Console.WriteLine("Que instrumento desea registrar?");
            Console.WriteLine("1. Guitarra");
            Console.WriteLine("2. Bajo");
            int option = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Marca del instrumento: ");
            string brand = Console.ReadLine();

            Console.WriteLine("modelo del instrumento: ");
            string model = Console.ReadLine();
            //Convert.ToDecimal(Console.ReadLine());
          
            Console.WriteLine("industria del instrumento: ");
            string industry = Console.ReadLine();

            Console.WriteLine("Anio del Instrumento: ");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Material del instrumento: ");
            string material = Console.ReadLine();

            Console.WriteLine("Precio: ");
            int price = Convert.ToInt32(Console.ReadLine());



            switch (option)
            {
                case 1:
                    instrumentsList.Add(new Guitar() { brand = brand, model = model, industry = industry, year = year, material = material, price = price });
                    break;
                case 2:
                    instrumentsList.Add(new Guitar() { brand = brand, model = model, industry = industry, year = year, material = material, price = price });
                    break;
                default:
                    break;
            }
        }

        public Instrument SearchIstrumentByModel()
        {
            Console.WriteLine("Instrumento a buscar (guitarra o bajo): ");
            string model = Console.ReadLine();

            foreach (var instrument in instrumentsList)
            {
                if (instrument.model == model)
                {
                    return instrument;
                }
            }
            return null;
        }


        public void CreateAReparation()
        {

            Console.WriteLine("Donde desea realizar la reparacion?");
            Console.WriteLine("1. A domicilio");
            Console.WriteLine("2. En tienda");
            int option = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Propietario del instrumento: ");
            string instrumentOwner = Console.ReadLine();
            Console.WriteLine("Precio de reparacion: ");
            int ReparationPrice = Convert.ToInt32(Console.ReadLine());
            Instrument instrument = SearchIstrumentByModel();

            switch (option)
            {
                case 1:
                    Console.WriteLine("Precio del Taxi: ");
                    int taxiPrice = Convert.ToInt32(Console.ReadLine());
                    reparationsList.Add(new House() { idReparation = reparationsList.Count, instrumentOwner = instrumentOwner, ReparationPrice = ReparationPrice, taxiPrice=taxiPrice, _instrument = instrument });
                    break;
                case 2:
                    reparationsList.Add(new Store() { idReparation = reparationsList.Count, instrumentOwner = instrumentOwner, ReparationPrice= ReparationPrice, _instrument = instrument });
                    break;
                default:
                    break;
            }
        }
        public void ShowInstruments()
        {
            Console.WriteLine("-----------------------------INSTRUMENTOS----------------------------");
            foreach (var instrument in instrumentsList)
            {

                instrument.ShowInstrument();

            }
        }

        public void ShowReparations()
        {
            Console.WriteLine("-----------------------------------REPARACIONES-----------------------------------");
            foreach (var reparation in reparationsList)
            {
                reparation.ShowReparation();
            }
        }
    }
}
