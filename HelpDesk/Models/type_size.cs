using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class type_size
    {
		public int tsID { get; set; }
		public string tsname { get; set; }
        public ICollection<HDD> HDD { get; set; }
        public ICollection<RAM> RAM { get; set; }
    }
}
