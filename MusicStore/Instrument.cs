using System;
using System.Collections.Generic;
using System.Text;

namespace MusicStore
{
    abstract class Instrument
    {
        public string brand { get; set; }
        public string model { get; set; }
        public string industry { get; set; }
        public int year { get; set; }
        public string material { get; set; }
        public int price { get; set; }

        public abstract void ShowInstrument();
    }
}
