using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace Registrasi.Models
{
	public class Attachmentt
	{
		[Key]
		public int AttachmentId { get; set; }
		public Agen Agen { get; set; }
        public string AttachmentType { get; set; }
		public string FileType { get; set; }
		public string FileName { get; set; }
		public string FilePath { get; set; }
		public DateTime CreateDate { get; set; }
		public string CreateBy { get; set; }
	}
}
