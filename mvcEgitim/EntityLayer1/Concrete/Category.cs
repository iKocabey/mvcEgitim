using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer1.Concreate
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }//Bu alanlar property
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(200)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }

        public ICollection<Heading> Headings { get; set; }//Buradaki T nin karşılığı entitydir.Biz burada Hangi sınıfla ilişkilendireceksek o sınıfı yazıyoruz.
    }
}
