using System;
using System.Collections.Generic;
using System.Text;

namespace Four
{
    public class ProductInvoice
    {
        public int ProductId { get; set; }
        public int InvoiceId { get; set; }
        public string ProductName { get; set; }
        public int InvoicePrice { get; set; }
        public int DetailsInvoiceCount { get; set; }
    }
}
