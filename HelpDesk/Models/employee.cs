using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class employee
    {
        public string emID { get; set; }
        public string empass { get; set; }
        public string emname { get; set; }
        public string emlastname { get; set; }
        public string secID { get; set; }
        public section section { get; set; }

        public ICollection<monitor> monitor { get; set; }

        public ICollection<monitor_brand> monitor_brand { get; set; }
    }
}