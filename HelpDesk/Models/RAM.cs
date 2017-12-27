using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class RAM
    {

        public string ramsnID { get; set; }
        public string rambrand { get; set; }
        public string rammodel { get; set; }
        public string size { get; set; }

        public int tsID { get; set; }
        public int staID { get; set; }
        public string comID { get; set; }
        public int rtid { get; set; }
        public DateTime rambdate { get; set; }

        public type_size type_size { get; set; }
        public statuscomponent statuscomponent { get; set; }

        public computer computer { get; set; }
        public RAM_Type RAM_Type { get; set; }

    }
}
