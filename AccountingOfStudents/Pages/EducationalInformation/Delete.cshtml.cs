using AccountingOfStudents.Data;
using AccountingOfStudents.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AccountingOfStudents.Pages.EducationalInformation
{
    public class DeleteModel : PageModel
    {
		private readonly DataContext _dataContext;
		private readonly ILogger<DeleteModel> _logger;
		[BindProperty]
		public InformationAboutEducation Information { get; set; }
		public string ErrorMessage { get; set; }

		public DeleteModel(DataContext dataContext, ILogger<DeleteModel> logger)
		{
			_dataContext = dataContext;
			_logger = logger;
		}
		public async Task<IActionResult> OnGetAsync(int? id, bool? saveChangesError = false)
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

			if (saveChangesError.GetValueOrDefault())
			{
				ErrorMessage = String.Format("Delete {Id} failed. Try again", id);
			}
			return Page();
		}

		public async Task<IActionResult> OnPostAsync(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var information = await _dataContext.InformationAboutEducations.FindAsync(id);

			if (information == null)
			{
				return NotFound();
			}

			try
			{
				_dataContext.InformationAboutEducations.Remove(information);
				await _dataContext.SaveChangesAsync();
				return RedirectToPage("./Index");
			}
			catch (DbUpdateException ex)
			{
				_logger.LogError(ex, ErrorMessage);

				return RedirectToAction("./Delete", new { id, saveChangesError = true });
			}
		}
	}
}
