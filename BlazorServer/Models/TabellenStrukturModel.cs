using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Models
{
    public class TabellenStrukturModel
    {
        public string table_schema { get; set; }
        public string table_name { get; set; }
        public string column_name { get; set; }
        public int ordinal_position { get; set; }
        public string data_type { get; set; }
        public int numeric_precision { get; set; }
        public string column_type { get; set; }
        public string column_default { get; set; }
        public string is_nullable { get; set; }
        public string column_comment { get; set; }
        public string column_key { get; set; }
        public string extra { get; set; }
    
    }
}
