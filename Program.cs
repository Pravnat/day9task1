using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day9t1
{
    class Program
    {
        static void Main(string[] args)
        {
			int companycount;
			Company[] users;
			Console.WriteLine("How many companys do you want to Enter:");
			companycount = int.Parse(Console.ReadLine());
			users = new Company[companycount];
			for (int i = 0; i < companycount; i++)
			{
				string name;
				string sector;
				string location;
				int age;
				Console.WriteLine("Enter the Name of the organisation:");
				name = Console.ReadLine();
				Console.WriteLine("Enter the Sector of the organisation:");
				sector = Console.ReadLine();
				Console.WriteLine("Enter the Location of the organisation:");
				location = Console.ReadLine();
				Console.WriteLine("Enter the Age of the organisation:");
				age = int.Parse(Console.ReadLine());
				Company c2 = new Company(name, sector, location, age);
				if (!users.Contains(c2))
				{
					users[i] = c2;
				}
				else
				{
					Console.WriteLine("Company is already present:");
					i--;
				}
			}
			foreach (var item in users)
			{
				Console.WriteLine(item.ToString());
			}
			Console.Read();
		}
    }
}
