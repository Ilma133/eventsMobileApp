using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlmaMeskic_studentaqEvents.models
{
    public class KlasaUsluge
    {
        public int id { get; set; }
        public String NazivKlase { get; set; }
        public String OznakaKvaliteta { get; set; }
        public int FaktorCijene { get; set; }
        public bool Ugovorena { get; set; }
    }
}
