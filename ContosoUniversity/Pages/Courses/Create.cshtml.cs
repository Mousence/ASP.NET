﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ContosoUniversity.Data;
using ContosoUniversity.Models;

namespace ContosoUniversity.Pages.Courses
{
	public class CreateModel : DepartmentNamePageModel
	{
		private readonly ContosoUniversity.Data.SchoolContext _context;

		public CreateModel(ContosoUniversity.Data.SchoolContext context)
		{
			_context = context;
		}

		public IActionResult OnGet()
		{
			PopulateDepartmentDropdownList(_context);
			//ViewData["DepartmentID"] = new SelectList(_context.Departments, "DepartmentID", "DepartmentID");
			return Page();
		}

		[BindProperty]
		public Course Course { get; set; } = default!;

		// For more information, see https://aka.ms/RazorPagesCRUD.
		public async Task<IActionResult> OnPostAsync()
		{
			Course emptyCourse = new Course();

			if (await TryUpdateModelAsync<Course>
				(
					emptyCourse,
					"course",
					s => s.CourseId, s => s.DepartmentID, s => s.Title, s => s.Credits
				)
			  )
			{
				_context.Courses.Add(emptyCourse);
				await _context.SaveChangesAsync();
				return RedirectToPage("./Index");
			}

			PopulateDepartmentDropdownList(_context, emptyCourse.DepartmentID);
			return Page();

			//if (!ModelState.IsValid)
			//{
			//	return Page();
			//}

			//_context.Courses.Add(Course);
			//await _context.SaveChangesAsync();

			//return RedirectToPage("./Index");
		}
	}
}
