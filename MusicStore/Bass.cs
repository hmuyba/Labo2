using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore
{
    class Bass:Instrument
    {
        public override void ShowInstrument()
        {
            Console.WriteLine($"\n");
            Console.WriteLine($"---------- BAJO -----------");
            Console.WriteLine($"Marca del Bajo: {brand}");
            Console.WriteLine($"Modelo del Bajo: {model}");
            Console.WriteLine($"industria del Bajo: {industry}");
            Console.WriteLine($"anio del Bajo: {year}");
            Console.WriteLine($"material del Bajo: {material}");
            Console.WriteLine($"precio del Bajo: {price}");
        }
    }
}
