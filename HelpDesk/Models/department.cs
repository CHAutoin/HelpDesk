using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class department
    {

        public string depID { get; set; }
        public string depname { get; set; }
        public ICollection<section> section { get; set; }

    }
}
