using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer1.Concreate
{
    public class Content
    {
        [Key]
        public int ContentId { get; set; }
        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }
        //contentYazar
        //ContentBaşlık
        public int HeadingId { get; set; }
        public virtual Heading Heading { get; set; }
        public int? WriterId { get; set; } //? işareti değerin nullaable olabileceğini söyler
        public virtual Writer Writer { get; set; }
        public bool ContentStatus { get; set; }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
