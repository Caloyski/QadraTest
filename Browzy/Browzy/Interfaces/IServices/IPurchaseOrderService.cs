using Browzy.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browzy.Interfaces.IServices {
    public interface IPurchaseOrderService {
        PurchaseOrder Purchase(PurchaseOrder purchaseOrder);
    }
}
