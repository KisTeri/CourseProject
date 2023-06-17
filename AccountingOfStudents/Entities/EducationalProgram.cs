namespace AccountingOfStudents.Entities
{
    public class EducationalProgram
    {
        public int Id { get; set; }
		public bool IsDeleted { get; set; }

		public string KindOfProgram { get; set; }
        public string NameOfProgram { get; set; }

        public ICollection<InformationAboutEducation> InformationAboutEducations { get; set; }
        public EducationalProgram() { }
    }
}
