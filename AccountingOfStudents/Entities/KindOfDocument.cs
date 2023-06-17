using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace AccountingOfStudents.Entities
{
    public class KindOfDocument
    {
        public int Id { get; set; }
		public bool IsDeleted { get; set; }

		public string Document { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
		public DateTime DateOfIssue { get; set; }

		public int InformationAboutEducationId { get; set; }

		public InformationAboutEducation InformationAboutEducations { get; set; }

		public KindOfDocument() { }
    }
}
