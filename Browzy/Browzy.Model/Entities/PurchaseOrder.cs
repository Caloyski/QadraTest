using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browzy.Model.Entities {

    public class PurchaseOrder {

        public int ID { get; set; }
        public decimal Total { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; }
    }
}
