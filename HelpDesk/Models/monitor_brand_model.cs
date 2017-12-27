using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class monitor_brand_model
    {

        public string mbmID { get; set; }
        public string mbmname { get; set; }

        public string mobID { get; set; }
        public ICollection<monitor> monitor { get; set; }
    }
}
