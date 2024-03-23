using Challenge1.Models;

namespace Challenge1.Data
{
	public static class DbData
	{
		public const string DbName = "XLENTDb";
		public static void AddMockData(TheAppContext context)
		{
			Customer customer1 = new Customer() { Id = 1, FirstName = "Lyn", LastName ="Gordon" };
			Customer customer2 = new Customer() { Id = 2, FirstName = "Donald", LastName = "Duck" };
			Customer customer3 = new Customer() { Id = 3, FirstName = "Clark", LastName = "Kent" };
			Customer customer4 = new Customer() { Id = 4, FirstName = "Nigel", LastName = "Sibbert" };


			context.Add(customer1);
			context.Add(customer2);
			context.Add(customer3);
			context.Add(customer4);
			context.SaveChanges();
		}
	}
}
