using Microsoft.AspNetCore.Mvc;

namespace AccountingOfStudents.Entities
{
    public class AssignedCategory
    {
        public int Id { get; set; }
		public bool IsDeleted { get; set; }

		public string Category { get; set; }

		public ICollection<InformationAboutEducation> InformationAboutEducations { get; set; }
		public AssignedCategory() { }

	}
}
