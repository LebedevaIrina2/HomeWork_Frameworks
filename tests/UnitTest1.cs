using Frameworks.business_object;
using Frameworks.service;
using Frameworks.service.ui;
using Frameworks.tests;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace PageObjects
{
    public class Tests2 : BaseTest
    {
        
        private AllProductsPage allProductpage;        
        private DeleteNewProduct deleteNewProduct;
        

        // Данные для проверки загрузки нужной страницы
        private NamePages namePage = new NamePages("Home page", "Login", "Product editing", "All Products");

        //  Данные для авторизации
        private LoginValue loginValue = new LoginValue("user", "user");

        // Данные для карточки с новым продуктом
        private Product product = new Product("King prawns", "Seafood", "Pavlova, Ltd.", "500", "24 pieces", "20", "3", "2", "true");


       

        // TEST 1. Autorization
        [Test]
        public void Test1_Autorization()
        {
            Login login = new Login(driver);
           
            Assert.AreEqual(namePage.NameLoginPage, login.PageAutorization()); // Проверка загрузки нужной страницы авторизации с текстом "Login" 
            LoginService.Autorization(loginValue, driver); // Авторизация
            Assert.AreEqual(namePage.NameHomePage, login.PageAutorization());// Проверка успешной авторизации - должна быть загружена страница "Home page"
        }
   


        // TEST 2. Adding  New Product
        [Test]
        public void Test2_Add_Product()
        {
            MainPage mainPage = new MainPage(driver);           
            AllProductsPage allProductsPage = new AllProductsPage(driver);

            LoginService.Autorization(loginValue, driver); // Авторизация
                       
            ProductAddService.AddNewProduct(product, driver);  // ЗАПОЛНЯЕМ КАРТОЧКУ ПРОДУКТА           
            Assert.AreEqual(product.SendKeysProductName, allProductsPage.SearchNewProductName(product)); // Проверка того, что новый продукт есть в списке
        }


        //TEST 3. New Product. Check Values
        [Test]
        public void Test3_Check_Value()
        {
            LoginService.Autorization(loginValue, driver); // Авторизация

            allProductpage = new AllProductsPage(driver);

            allProductpage.SelectAllProducts(); // заходим на стр. "All Products"   
            allProductpage.SelectLinkProductName(product); //Заходим в карточку продукта
           
            Assert.AreEqual(product.SendKeysProductName, allProductpage.CheckProductName()); // Проверка названия продукта
            Assert.AreEqual(product.SelectCategoryId, allProductpage.CheckCategoryId());
            Assert.AreEqual(product.SelectSupplierId, allProductpage.CheckSupplierID());
            Assert.AreEqual(product.SendKeysQuantityPerUnit, allProductpage.CheckQuantityPerUnit());
            Assert.AreEqual(product.SendKeysUnitPrice, allProductpage.CheckUnitPrice());
            Assert.AreEqual(product.SendKeysUnitsInStock, allProductpage.CheckUnitsInStock());
            Assert.AreEqual(product.SendKeysUnitsOnOrder, allProductpage.CheckUnitsOnOrder());
            Assert.AreEqual(product.SendKeysReorderLevel, allProductpage.CheckReorderLevel());
            Assert.AreEqual(product.SelectDiscontinuedl, allProductpage.CheckDiscontinuedl()); 
        }


        //TEST 4. Delete Created Products
        [Test]
        public void Test4_Delete()
        {
            deleteNewProduct = new DeleteNewProduct(driver);

            LoginService.Autorization(loginValue, driver); // Авторизация           

            deleteNewProduct.RemoveProducts (product.SendKeysProductName);     // Удаляем продукт
            Assert.AreEqual(false, deleteNewProduct.isElementPresent(product.SendKeysProductName)); // Проверка успешного удаления продукта 
        }


        //Test 5. Logout
        [Test]
        public void Test5_Logout()
        {
            Login login = new Login(driver);
            LoginService.Autorization(loginValue, driver); // Авторизация

            login.Logout(); //LOGOUT
            Assert.AreEqual(namePage.NameLoginPage, login.PageAutorization());// Проверка успешного выхода из аккаунта, т.е. мы должны оказаться на странице "Login";

            LoginService.Autorization(loginValue, driver); // Авторизация
        }

    }
}

    


