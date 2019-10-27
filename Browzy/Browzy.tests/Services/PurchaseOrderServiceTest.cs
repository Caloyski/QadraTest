using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Browzy.Interfaces.IServices;
using Browzy.Implementations.Services;
using Browzy.Model.Entities;

namespace Browzy.tests.Services {

    [TestClass]
    public class PurchaseOrderServiceTest {

        [TestInitialize]
        public void Initialize() {
        }

        [TestCleanup]
        public void Cleanup() {
        }

        [DataTestMethod]
        public void Purchase_WithPassingParams_PurchaseCreated() {

            //Arrange
            Customer customer = FakeCustomer(MembershipType.Book);
            List<Product> products = new List<Product>();
            products.Add(FakeBook_Digital());

            //Act
            PurchaseOrderService target = new PurchaseOrderService();
            target.Purchase(customer.ID, products);

            //Assert

        }

        private Customer FakeCustomer(MembershipType membershipType) {

            Customer customer = new Customer();
            customer.ID = 1001;
            customer.FirstName = "Carlo Alfio";
            customer.LastName = "Flores";
            customer.Membership = membershipType;
            customer.DateOfBirth = DateTime.Parse("12/05/1988");
            customer.Email = "cagflores@gmail.com";

            return customer;

        }

        private Product FakeBook_Digital() {

            Book book = new Book();
            book.Title = "Kane and Abel";
            book.Description = "A story about two strangers.";
            book.ISBN = "fakeisbn110202";
            book.IsDigital = true;
            book.Pages = 598;
            book.Price = 9.99m;

            return book;
        }

    }
}
