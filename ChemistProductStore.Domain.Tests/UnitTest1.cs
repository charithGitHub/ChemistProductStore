using NUnit.Framework;
using ChemistProductStore.Core.Model;
using ChemistProductStore.Domain;
using System;

namespace ChemistProductStore.Domain.Tests
{
    public class ProductTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ProductShouldCreatesuccessfully()
        {
            var product = Product.Create("Test Product 1", 10.50, "Books", true);

            var instance = BaseAggregateRoot<Product, Guid>.Create(product.Events);

            Assert.IsTrue(instance != null);
        }
    }
}