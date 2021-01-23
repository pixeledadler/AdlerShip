using System;
namespace Adler.System.Ship.Models
{
    public class CrewMembers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public RollList Roll { get; set; }
        public DateTime DateOfBirth { get; set; }
        public CrewContact Contact { get; set; }

    }
    
}