using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Models
{
    public class ImpfAdressModel
    {
        public int adr_Id { get; set; }
        public string adr_Strasse { get; set; }
        public string adr_PLZ { get; set; }
        public string adr_Ort { get; set; }
        public string Name { get; set; }
        public string Adresse { get; set; }
    }
}
