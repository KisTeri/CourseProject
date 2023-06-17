using AccountingOfStudents.Data;
using AccountingOfStudents.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AccountingOfStudents.Pages.EducationalInformation
{
    public class EditModel : PageModel
    {
		private readonly DataContext _dataContext;

		[BindProperty]
		public InformationAboutEducation Information { get; set; }
		public SelectList Categories { get; set; }
		public SelectList Organizations { get; set; }

		public EditModel(DataContext dataContext)
		{
			_dataContext = dataContext;
		}

		public void DropDownLists(object selectedCategory, object selectedOrganization)
		{
			var categoryQuery = from c in _dataContext.AssignedCategories
								select c;

			var organizationQuery = from o in _dataContext.SendingOrganizations
									select o;

			Categories = new SelectList(categoryQuery.AsNoTracking(),
				nameof(AssignedCategory.Id),
				nameof(AssignedCategory.Category),
				selectedCategory);

			Organizations = new SelectList(organizationQuery.AsNoTracking(),
				nameof(SendingOrganization.Id),
				nameof(SendingOrganization.Organization),
				selectedOrganization);
		}

		[HttpGet]
		public IActionResult OnGet(int id)
		{
			Information = _dataContext.InformationAboutEducations
				.Include(p => p.EducationalProgram)
				.Include(p => p.KindOfDocument)
				.Include(p => p.PersonalInformationOfStudent)
				.Include(p => p.AssignedCategory)
				.Include(p => p.SendingOrganization)
				.FirstOrDefault(m => m.Id == id);

			if (id == null || _dataContext.InformationAboutEducations == null || _dataContext.EducationalPrograms == null
				|| _dataContext.KindOfDocuments == null || _dataContext.PersonalInformationOfStudents == null
				|| _dataContext.AssignedCategories == null || _dataContext.SendingOrganizations == null)
			{
				return NotFound();
			}

			DropDownLists(_dataContext, _dataContext);

			return Page();
		}


		[HttpPut]
		public IActionResult OnPost()
		{
			_dataContext.InformationAboutEducations.Update(Information);
			_dataContext.SaveChanges();
			return RedirectToPage("/EducationalInformation/Index");
		}
	}
}
