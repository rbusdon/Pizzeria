using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseHandler.Models
{
    public class Receipt
    {
        public int ReceiptId { get; set; }
        public int Total { get; set; }
        public DateTime? DateOfOrder { get; set; }
        public virtual Order OrderId { get; set; } = null!;
    }
}
