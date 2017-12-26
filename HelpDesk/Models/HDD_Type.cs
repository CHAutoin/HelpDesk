using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class HDD_Type
    {
        public int htid { get; set; }
        public string htname { get; set; }
        public ICollection<HDD> HDD { get; set; }
    }
}
