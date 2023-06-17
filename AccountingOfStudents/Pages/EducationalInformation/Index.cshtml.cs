using AccountingOfStudents.Data;
using AccountingOfStudents.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Extensions.Configuration;
using AccountingOfStudents.Dtos;

namespace AccountingOfStudents.Pages.EducationalInformation
{
    public class IndexModel : PageModel
    {
		private readonly DataContext _dataContext;
		private readonly IConfiguration _configuration;
		public IEnumerable<InformationAboutEducation> Information { get; set; }
		public PaginatedList<InformationAboutEducation> PaginatedInformation { get; set; }

		public string NameSort { get; set; }
		public string IdSort { get; set; }

		public string CurrentFilter { get; set; }
		public string CurrentSort { get; set; }

		[BindProperty(SupportsGet = true)]
		public string? SearchString { get; set; }

		public IndexModel(DataContext dataContext, IConfiguration configuration)
		{
			_dataContext = dataContext;
			_configuration = configuration;
		}

		[HttpGet]
		public async Task OnGetInfAsync()
		{
			Information = await _dataContext.InformationAboutEducations
				.Include(p => p.EducationalProgram)
				.Include(p => p.AssignedCategory)
				.Include(p => p.KindOfDocument)
				.Include(p => p.PersonalInformationOfStudent)
				.Include(p => p.SendingOrganization)
				.ToListAsync();
		}

		[HttpGet]
		public async Task OnGetAsync(string sortOrder,  int? pageIndex)
		{
			CurrentSort = sortOrder;

			NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
			IdSort = sortOrder == "id_asc" ? "id_desc" : "id_asc";

			CurrentSort = sortOrder;

			if (SearchString != null)
			{
				pageIndex = 1;
			}
			else
			{
				SearchString = CurrentFilter;
			}

			CurrentFilter = SearchString;

			IQueryable<InformationAboutEducation> Inf = from s in _dataContext.InformationAboutEducations
														.Include(p => p.EducationalProgram)
														.Include(p => p.AssignedCategory)
														.Include(p => p.KindOfDocument)
														.Include(p => p.PersonalInformationOfStudent)
														.Include(p => p.SendingOrganization)
														select s;

			if (!string.IsNullOrEmpty(SearchString))
			{
				Inf = Inf.Where(s => s.PersonalInformationOfStudent.LastName.Contains(SearchString)
									   || s.PersonalInformationOfStudent.FirstName.Contains(SearchString)
									   || s.PersonalInformationOfStudent.MiddleName.Contains(SearchString));
			}

			Information = await Inf.ToListAsync();

			switch (sortOrder)
			{
				case "name_desc":
					Inf = Inf.OrderByDescending(s => s.PersonalInformationOfStudent.LastName);
					break;
				case "name_asc":
					Inf = Inf.OrderBy(s => s.PersonalInformationOfStudent.LastName);
					break;
				case "id_desc":
					Inf = Inf.OrderByDescending(s => s.PersonalInformationOfStudent.Id);
					break;
				case "id_asc":
					Inf = Inf.OrderBy(s => s.PersonalInformationOfStudent.Id);
					break;
			}

			var pageSize = _configuration.GetValue("PageSize", 5);
			PaginatedInformation = await PaginatedList<InformationAboutEducation>.CreateAsync(
				Inf.AsNoTracking(), pageIndex ?? 1, pageSize);

			//Information = await Inf.AsNoTracking().ToListAsync();
		}
	}
}
