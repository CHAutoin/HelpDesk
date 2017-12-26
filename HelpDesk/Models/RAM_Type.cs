using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class RAM_Type
    {

        public int rtid { get; set; }
        public string rtname { get; set; }
        public ICollection<RAM> RAM { get; set; }

    }
}
