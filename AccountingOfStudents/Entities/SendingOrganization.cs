using System.ComponentModel.DataAnnotations;

namespace AccountingOfStudents.Entities
{
    public class SendingOrganization
    {
		public int Id { get; set; }
		public bool IsDeleted { get; set; }

		public string Organization { get; set; }

		public ICollection<InformationAboutEducation> InformationAboutEducations { get; set; }
		public SendingOrganization() { }
    }
}
