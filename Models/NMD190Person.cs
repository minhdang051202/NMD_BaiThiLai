using System.ComponentModel.DataAnnotations;

namespace BaiThiLai.Models
{
    public class NMD190Person
    {
        [Key]
        public string PersonID { get; set; }
        public string Fullname { get; set; }
        public string Address { get; set; }
    }
}