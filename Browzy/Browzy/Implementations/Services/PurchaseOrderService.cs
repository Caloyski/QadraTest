using Browzy.Interfaces.IServices;
using Browzy.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Browzy.Implementations.Services {
    public class PurchaseOrderService : IPurchaseOrderService {
        public PurchaseOrder Purchase(PurchaseOrder purchaseOrder) {

            //TODO: Don't allow to buy multiple memberships on a single purchase order

            var membership = purchaseOrder.Products.Where(x => x.GetType() == typeof(Membership)).SingleOrDefault();

            if(membership != null) {

                //Get Customer from database
                //Check if Customer exists. If not, throw exception
                //Modify Customer membership

            }

            //Check if type of membership is allowed to purchase all the products in the order.

            

            return null;
        }
    }
}