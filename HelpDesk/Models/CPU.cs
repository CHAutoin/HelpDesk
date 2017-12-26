using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HelpDesk.Models
{
    public class CPU
    {
        public string cpusnID { get; set; }
        public string cpubrand { get; set; }
        public string cpumodel { get; set; }
        public string socket { get; set; }
        public int stID { get; set; }
        public string comID { get; set; }
        public DateTime cpubdate { get; set; }
        public statuscomponent statuscomponent { get; set; }
        public computer computer { get; set; }

    }
}
