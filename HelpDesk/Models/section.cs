using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class section
    {
        public string secID { get; set; }
        public string secname { get; set; }
        public string depID { get; set; }
        public department department { get; set; }


    }
}