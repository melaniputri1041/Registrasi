using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace Registrasi.Models
{
	public class Agen
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AgenId { get; set; }
		public DateTime RegDate { get; set; }
		public string RegStatus { get; set; }
		public string Name { get; set; }
		public string Gender { get; set; }
		public string BirthPlace { get; set; }
		public DateTime BirthDate { get; set; }
		public string Addrres { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public string IdCard { get; set; }
		public DateTime CreateDate { get; set; }
		public string CreateBy { get; set; }

        public static implicit operator DbSet<object>(Agen v)
        {
            throw new NotImplementedException();
        }
    }
}
