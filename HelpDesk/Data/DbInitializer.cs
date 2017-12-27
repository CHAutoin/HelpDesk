using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpDesk.Models;
namespace HelpDesk.Data
{
    public class DbInitializer
    {
		public static void Initialize(HelpDeskContext context)
		{
			//EnsureCreated() เป็นคำสั่งตัวเช็คว่าถ้า ฐานข้อมูล หรือ database มีการสร้างอยู่แล้ว ก็จะไม่สร้าง แต่ถ้าไม่ก็จะสร้างฐานข้อมูลพร้อม schemas
			context.Database.EnsureCreated();

			if (context.roless.Any())
			{
				return;
			}
			var roles1 = new roles[]
				{
					new roles{rolesid=3,rolesname="testroles3"}
				};

			foreach (roles i in roles1)
			{
				context.roless.Add(i);
			}
			context.SaveChanges();
		}
    }
}
