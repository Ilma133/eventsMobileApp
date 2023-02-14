using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlmaMeskic_studentaqEvents.models
{
    public class VrstaUsluge
    {
        public int id { get; set; }
        public String Ikona { get; set; }
        public String Naziv { get; set; }
        public float Cijena { get; set; }
        public bool Ugovorena { get; set; }
    }
}
