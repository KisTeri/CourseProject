using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountingOfStudents.Entities
{
    public class PersonalInformationOfStudent
    {
		public int Id { get; set; }
		public bool IsDeleted { get; set; }

		public string LastName { get; set; }
		public string FirstName { get; set; }
		public string MiddleName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Snils { get; set; }
		public string CompletedEducation { get; set; }
		public string Citizenship { get; set; }

		public int InformationAboutEducationId { get; set; }

		public ICollection<InformationAboutEducation> InformationAboutEducations { get; set; }

		public PersonalInformationOfStudent() { }
	}
}
