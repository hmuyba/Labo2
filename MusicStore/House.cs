using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore
{
    class House : Reparation
    {
        public int taxiPrice { get; set; }
        public override decimal CalculatePriceOfReparation()
        {
            ReparationPrice = ReparationPrice + taxiPrice;
            return ReparationPrice;
        }

        public override void ShowReparation()
        {
            Console.WriteLine($"---------- REPARACION A DOMICILIO-----------");
            Console.WriteLine($"--> INSTRUMENTO <--:");
            _instrument.ShowInstrument();
            Console.WriteLine($"Propietario del instrumento: {instrumentOwner}");
            decimal reparationPrice = CalculatePriceOfReparation();
            Console.WriteLine($"Precio de reparacion mas envio: {reparationPrice}");
            Console.WriteLine($"Precio del taxi: {taxiPrice}");
            Console.WriteLine($"\n");
        }
    }
}
