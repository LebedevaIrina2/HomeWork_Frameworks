using Frameworks.business_object;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PageObjects
{
    class AllProductsPage
    {
        private IWebDriver driver;
        public AllProductsPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        private IWebElement linkAllProducts => driver.FindElement(By.XPath("//a[(text()=\"All Products\")]"));

        public string CheckNameAllProductsPage() { return linkAllProducts.Text;}
        public void SelectAllProducts() { linkAllProducts.Click(); } // Переход по ссылке All Products
        public string SelectProductsNamePage(NamePages namePages) { return linkAllProducts.Text; } // Проверяем загрузку нужной страницы "Product editing"

        public string SearchNewProductName(Product product) { return driver.FindElement(By.XPath($"//a[contains(text(), '{product.SendKeysProductName}')]")).Text; }
        public void SelectLinkProductName(Product product) {
            new Actions(driver).Click(driver.FindElement(By.XPath($"//a[text()=\"{product.SendKeysProductName}\"]"))).SendKeys(Keys.Enter).Build().Perform();
        }


        public string CheckProductName() {return driver.FindElement(By.Id("ProductName")).GetAttribute("value"); } //Проверяем название продукта
        public string CheckCategoryId() { return driver.FindElement(By.XPath($"//*[@id=\"CategoryId\"]/option[9]")).Text; } // Проверяем поставщика
        public string CheckSupplierID() { return driver.FindElement(By.XPath($"//*[@id=\"SupplierId\"]/option[8]")).Text; }
        
        public string CheckUnitPrice() 
        {
            return driver.FindElement(By.Id("UnitPrice")).GetAttribute("value").Replace(",0000","");
            
        }
        public string CheckQuantityPerUnit() { return driver.FindElement(By.Id("QuantityPerUnit")).GetAttribute("value"); }
        public string CheckUnitsInStock() { return driver.FindElement(By.Id("UnitsInStock")).GetAttribute("value"); }
        public string CheckUnitsOnOrder() { return driver.FindElement(By.Id("UnitsOnOrder")).GetAttribute("value"); }
        public string CheckReorderLevel() { return driver.FindElement(By.Id("ReorderLevel")).GetAttribute("value"); }
        public string CheckDiscontinuedl() { return driver.FindElement(By.Id("Discontinued")).GetAttribute("value"); }
                      
    }
}
