using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class monitor_brand
    {

        public string mobID { get; set; }
        public string mobname { get; set; }
        public string model { get; set; }
        public string emID { get; set; }

        public employee employee { get; set; }



    }
}
