using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKTX.Domains.Entities
{
    public class Invoice : Entity
    {
        public DateTime IssueDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } // Paid, Unpaid

        public int RoomId { get; set; }
        public Room Room { get; set; }

        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }

    public class InvoiceDetail : Entity
    {
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public int Quantity { get; set; } // Số lượng (kWh, m3, etc.)
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; } // Quantity * UnitPrice
    }

    public class Service : Entity
    {
        public string ServiceName { get; set; } 
        public string Unit { get; set; } // kWh, m3, VND
    }
}
