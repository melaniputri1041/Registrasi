using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace Registrasi.Models
{
	public class WorkExperience
	{
		[Key]
		public int WorkExperienceId { get; set; }
        public Agen Agen { get; set; }
        public string Company { get; set; }

		public string Field { get; set; }

		public string Position { get; set; }

		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		public string JobDesc { get; set; }

		public DateTime CreateDate { get; set; }

		public string CreateBy { get; set; }
	}
}
