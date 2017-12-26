using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HelpDesk.Models
{
    public class user
    {
		public string uid { get; set; }
		public string upass { get; set; }
		public string uname { get; set; }
		public string ulastname { get; set; }
		public int rolesid { get; set; }

		public roles roles { get; set; }


    }
}
