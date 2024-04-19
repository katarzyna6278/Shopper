using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shopper;

namespace Shopper.Tests
{
    public class CartTests
    {
        //NazwaTestowanejMetody_TestowanyScenariusz_OczekiwanyRezultat
        public Cart Cart { get; set; }
        public Product Product { get; set; }


        [SetUp]
        public void Setup()
        {
            Product = new Product("Mysz komputerowa", "Normalna mysz do komputera", 99.90m, "black");
            Cart = new Cart();

            Cart.Products.Add(Product);
            Cart.Value += Product.Price;
        }

        [Test]
        public void Add_WhenAProductIsAddedToCart_TheCountIsIncreased()
        {
            //Triple A rule (zasada 3 'a')
            //arrange
            var cartCount = Cart.Products.Count;    //1

            //act
            Cart.Add(Product);                      //Cart.Products.Count = 2

            //assert
            Assert.That(Cart.Products.Count, Is.EqualTo(cartCount + 1));
        }

        [Test]
        public void Add_WhenAProductIsAddedToCart_TheValueIsRecalculated()
        {
            //Triple A rule (zasada 3 'a')
            //arrange
            var cartValue = Cart.Value;

            //act
            Cart.Add(Product);

            //assert
            Assert.That(Cart.Value, Is.EqualTo(Product.Price + cartValue));
        }

        [Test]
        public void Add_WhenANullParameterIsPassed_ThrowsArgumentNullException()
        {
            //Triple A rule (zasada 3 'a')
            //arrange
            //act
            //assert
            Assert.Throws<ArgumentNullException>(() => Cart.Add(null));
        }

        [Test]
        public void Remove_WhenAProductIndexIsPassed_CountOfProductsIsDecreased()
        {
            //arrange
            var cartCount = Cart.Products.Count;

            //act
            Cart.Remove(1);

            //assert
            Assert.That(Cart.Products.Count, Is.EqualTo(cartCount - 1));
        }

        [Test]
        public void Remove_WhenAProductIndexIsPassed_ValueIsDecreased()
        {
            //arrange
            var cartValue = Cart.Value;

            //act
            Cart.Remove(1);

            //assert
            Assert.That(Cart.Value, Is.EqualTo(cartValue - Product.Price));
        }
    }
}