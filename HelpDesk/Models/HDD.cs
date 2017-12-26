using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class HDD
    {

        public string hddsn { get; set; }
        public string hddbrand { get; set; }
        public string hddmodel { get; set; }

        public string size { get; set; }

        public int tsid { get; set; }
        public int staid { get; set; }
        public string comid { get; set; }
        public int htid { get; set; }
        public DateTime hddbdate { get; set; }

        public type_size type_size { get; set; }
        public statuscomponent statuscomponent { get; set; }
        public computer computer { get; set; }

        public HDD_Type HDD_Type { get; set; }
    }
}
