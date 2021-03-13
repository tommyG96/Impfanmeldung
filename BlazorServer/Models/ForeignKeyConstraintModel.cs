using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Models
{
    public class ForeignKeyConstraintModel
    {
        public string constraint_name { get; set; }
        public string table_name { get; set; }
        public string column_name { get; set; }
        public string referenced_table_name { get; set; }
        public string referenced_column_Name { get; set; }
        public string update_rule { get; set; }
        public string delete_rule { get; set; }

    }
}
