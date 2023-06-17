using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AccountingOfStudents.Entities
{
    public class InformationAboutEducation
    {
		public int Id { get; set; }
		public bool IsDeleted { get; set; }

		public string ContractNumber { get; set; }
        public DateTime StartOfEducation { get; set; }
		public DateTime EndOfEducation { get; set; }
        public string ProtocolNumber { get; set; }

		public int EducationalProgramId { get; set; }
		public int AssignedCategoryId { get; set; }
		public int PersonalInformationOfStudentId { get; set; }
		public int KindOfDocumentId { get; set; }
		public int SendingOrganizationId { get; set; }

		public EducationalProgram EducationalProgram { get; set; }
		public AssignedCategory AssignedCategory { get; set; }
        public PersonalInformationOfStudent PersonalInformationOfStudent { get; set; }
        public KindOfDocument KindOfDocument { get; set; }
		public SendingOrganization SendingOrganization { get; set; }
        public InformationAboutEducation() { }
	}
}
