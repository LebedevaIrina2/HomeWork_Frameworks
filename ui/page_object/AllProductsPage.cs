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
        private IWebElement productName => driver.FindElement(By.Id("ProductName"));
        private IWebElement categoryId => driver.FindElement(By.XPath($"//*[@id=\"CategoryId\"]/option[9]"));
        private IWebElement supplierId => driver.FindElement(By.XPath($"//*[@id=\"SupplierId\"]/option[8]"));
        private IWebElement unitPrice => driver.FindElement(By.Id("UnitPrice"));
        private IWebElement quantityPerUnit => driver.FindElement(By.Id("QuantityPerUnit"));
        private IWebElement unitsInStock => driver.FindElement(By.Id("UnitsInStock"));
        private IWebElement unitsOnOrder => driver.FindElement(By.Id("UnitsOnOrder"));
        private IWebElement reorderLevel => driver.FindElement(By.Id("ReorderLevel"));
        private IWebElement discontinued => driver.FindElement(By.Id("Discontinued"));



        public string CheckNameAllProductsPage() { return linkAllProducts.Text;}
        public void SelectAllProducts() { linkAllProducts.Click(); } // Переход по ссылке All Products
        public string SelectProductsNamePage(NamePages namePages) { return linkAllProducts.Text; } // Проверяем загрузку нужной страницы "Product editing"

        public string SearchNewProductName(Product product) { return driver.FindElement(By.XPath($"//a[contains(text(), '{product.SendKeysProductName}')]")).Text; }
       
        public void SelectLinkProductName(Product product) 
        {
            new Actions(driver).Click(driver.FindElement(By.XPath($"//a[text()=\"{product.SendKeysProductName}\"]"))).SendKeys(Keys.Enter).Build().Perform();  
        }

        public string CheckProductName() {return productName.GetAttribute("value"); } //Проверяем название продукта
        public string CheckCategoryId() { return categoryId.Text; } // Проверяем категорию
        public string CheckSupplierID() { return supplierId.Text; }
        
        public string CheckUnitPrice() 
        {
            return unitPrice.GetAttribute("value").Replace(",0000",""); //Вместо значения "500" возвращает "500,0000", исправляем это Replace
        }

        public string CheckQuantityPerUnit() { return quantityPerUnit.GetAttribute("value"); }
        public string CheckUnitsInStock() { return unitsInStock.GetAttribute("value"); }
        public string CheckUnitsOnOrder() { return unitsOnOrder.GetAttribute("value"); }
        public string CheckReorderLevel() { return reorderLevel.GetAttribute("value"); }
        public string CheckDiscontinuedl() { return discontinued.GetAttribute("value"); }
                      
    }
}
