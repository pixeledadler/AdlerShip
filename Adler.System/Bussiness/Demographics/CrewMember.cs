using System;

namespace Adler.System.Bussiness.Demographics
{
	public class CrewMember
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public Contact Contact { get; set; }
	}
}