using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class roles
    {

	    public int rolesID { get; set; }
		public string rolesname { get; set; }
		public ICollection<user> user { get; set; }
    }
}
