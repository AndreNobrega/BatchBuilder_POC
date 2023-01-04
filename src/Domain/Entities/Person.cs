namespace Domain.Entities
{
	public class Person
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Password { get; set; }
		public string? Email { get; set; }

		public Person(string name, string password)
		{
			Name = name;
			Password = password;
		}
	}
}
