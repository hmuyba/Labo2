using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore
{
    abstract class Reparation
    {
        public Instrument _instrument;
        public int idReparation { get; set; }
        public string instrumentOwner { get; set; }

        public int ReparationPrice;

        public abstract decimal CalculatePriceOfReparation();
        public abstract void ShowReparation();
       
    }
}
