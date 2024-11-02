using Microsoft.AspNetCore.Cors;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
	public class Student
	{
		public int ID { get; set; }
		[Required]
		[StringLength(50, ErrorMessage = "Too many symbols for LastName")]
		[Display(Name = "LastName")]
		public string LastName { get; set; }
		[Required]
		[StringLength(50, ErrorMessage = "Too many symbols for FirstName")]
		[Display(Name = "FirstName")]
		public string FirstName { get; set; }
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		[Display(Name = "Enrollment Date")]
		public DateTime EnrollmentDate { get; set; }
		[Display(Name = "Full name")]
		public string FullName //calculated property
		{
			get => LastName + " " + FirstName;
		}

		//Navigation property:
		public ICollection<Enrollment> Enrollments { get; set; }
	}
}
