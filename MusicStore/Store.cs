using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore
{
    class Store : Reparation
    {
        public override decimal CalculatePriceOfReparation()
        {
            return ReparationPrice;
        }

        public override void ShowReparation()
        {
            Console.WriteLine($"---------- REPARACION EN TIENDA -----------");
            Console.WriteLine($"--> INSTRUMENTO <--:");
            _instrument.ShowInstrument();
            Console.WriteLine($"Propietario del instrumento: {instrumentOwner}");
            Console.WriteLine($"Precio de reparacion: {ReparationPrice}");
            Console.WriteLine($"\n");
        }
    }
}
