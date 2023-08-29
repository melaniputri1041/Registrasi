using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Registrasi.Models
{
    public class Kombinasi
    {
        public int Id { get; set; }
        public List<Agen> Agen { get; set; }
        public List<WorkExperience> WorkExperience { get; set; }
        public List<Attachmentt> Attachmentt { get; set; }
        public List<Education> Education { get; set; }
    }
}
