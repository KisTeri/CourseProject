using AccountingOfStudents.Data;
using AccountingOfStudents.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Data.SqlClient;

namespace AccountingOfStudents.Pages.EducationalInformation
{
	
	public class CreateModel : PageModel
    {
		private readonly DataContext _dataContext;
		[BindProperty]
		public InformationAboutEducation Information { get; set; }
		public SelectList Categories { get; set; }
		public SelectList Organizations { get; set; }

		public CreateModel(DataContext dataContext)
		{
			_dataContext = dataContext;
		}

		public void DropDownLists(object selectedCategory = null, object selectedOrganization = null)
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
		public void OnGet()
		{
			DropDownLists(_dataContext);
		}

		[HttpPost]
		public IActionResult OnPost()
		{
			_dataContext.InformationAboutEducations.Add(Information);
			_dataContext.SaveChanges();
			return RedirectToPage("/EducationalInformation/Index");
		}
	}
}
