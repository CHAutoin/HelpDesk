using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class monitor
    {
        public string sn { get; set; }
        public string emid { get; set; }
        public string mbmid { get; set; }
        public DateTime bdate { get; set; }



        public employee employee { get; set; }
        public monitor_brand_model monitor_Brand_Model { get; set; }

    }
}
