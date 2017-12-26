using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class statuscomponent
    {

        public int stid { get; set; }
        public string stname { get; set; }
        public ICollection<CPU> CPU { get; set; }
        public ICollection<HDD> HDD { get; set; }
        public ICollection<RAM> RAM { get; set; }
    }
}
