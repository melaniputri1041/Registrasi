using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace Registrasi.Models
{
	public class Education
	{
		[Key]
		public int EducationId { get; set; }
        public Agen Agen { get; set; }
        public string Starta { get; set; }
		public string Institution { get; set; }
		public string Major { get; set; }
		public string GPA { get; set; }
		public DateTime StarDate { get; set; }
		public DateTime EndDate { get; set; }
		public DateTime CreateDate { get; set; }
		public string CreateBy { get; set; }

	}
}
