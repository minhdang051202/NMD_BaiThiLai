using System.ComponentModel.DataAnnotations;

namespace BaiThiLai.Models
{
    public class testktra
    {
        [Key]
        public string Ten { get; set; }
        public string Lop { get; set; }
        public string SinhVien { get; set; }
    }
    
}