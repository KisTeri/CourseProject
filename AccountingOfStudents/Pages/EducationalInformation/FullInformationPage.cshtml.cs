using AccountingOfStudents.Data;
using AccountingOfStudents.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading;

namespace AccountingOfStudents.Pages.EducationalInformation
{
    public class FullInformationPageModel : PageModel
    {
        private readonly DataContext _dataContext;

		public InformationAboutEducation Information { get; set; }

		public FullInformationPageModel(DataContext dataContext)
        {
            _dataContext = dataContext;
		}

		public async Task<IActionResult> OnGetAsync(int id)
		{
			if (id == null)
			{
				return NotFound();
			}

			Information = await _dataContext.InformationAboutEducations
				.Include(p => p.EducationalProgram)
				.Include(p => p.AssignedCategory)
				.Include(p => p.KindOfDocument)
				.Include(p => p.PersonalInformationOfStudent)
				.Include(p => p.SendingOrganization)
				.AsNoTracking()
				.FirstOrDefaultAsync(m => m.Id == id);

			if (Information == null)
			{
				return NotFound();
			}
			return Page();
		}
	}
}
