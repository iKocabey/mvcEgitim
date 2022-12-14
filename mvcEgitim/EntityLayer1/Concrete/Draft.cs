using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer1.Concrete
{
    public class Draft
    {
        [Key]//Burası annotations dur
        public int MessageId { get; set; }
        [StringLength(50)]
        public string SenderMessage { get; set; }
        [StringLength(50)]
        public string ReceiverMessage { get; set; }
        [StringLength(100)]
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public DateTime MessageDate { get; set; }
    }
}
