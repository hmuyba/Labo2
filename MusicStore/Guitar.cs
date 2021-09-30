using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore
{
    class Guitar:Instrument
    {
        public override void ShowInstrument()
        {
            Console.WriteLine($"\n");
            Console.WriteLine($"---------- GUITARRA -----------");
            Console.WriteLine($"Marca de la Guitarra: {brand}");
            Console.WriteLine($"Modelo de la Guitarra: {model}");
            Console.WriteLine($"industria de la Guitarra: {industry}");
            Console.WriteLine($"anio de la Guitarra: {year}");
            Console.WriteLine($"material de la Guitarra: {material}");
            Console.WriteLine($"precio de la Guitarra: {price}");
        }
    }
}
