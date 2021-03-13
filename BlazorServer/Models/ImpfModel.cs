using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Models
{
    public class ImpfModel
    {
        public int per_Id { get; set; }
        public string per_Vname { get; set; }
        public string per_Nname { get; set; }
        public DateTime per_GebDat { get; set; }
        public string per_svnr { get; set; }
        public int imp_Id { get; set; }
        public DateTime imp_Termin { get; set; }
        public int adr_Id { get; set; }
        public string adr_Strasse { get; set; }
        public string adr_PLZ { get; set; }
        public string adr_Ort { get; set; }
        public string Name { get; set; }
        public string Adresse { get; set; }
    }
}
