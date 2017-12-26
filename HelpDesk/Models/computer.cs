using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace HelpDesk.Models
{
    public class computer
    {
        public string comID { get; set; }
        public string comname { get; set; }
        public string comip { get; set; }
        public string commac { get; set; }
        public DateTime comdate { get; set; }
        public string emID { get; set; }

        public ICollection<CPU> CPU { get; set; }

        public ICollection<HDD> HDD { get; set; }
        public ICollection<RAM> RAM { get; set; }

        public employee employee { get; set; }
    }
}
