using Frameworks.business_object;
using OpenQA.Selenium;
using PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Frameworks.service
{
    class ProductAddService
    {
        public static void AddNewProduct(Product product, IWebDriver driver)
        {
            //AllProductsPage allProducts = new AllProductsPage(driver);
            NewProducts newProducts = new NewProducts(driver);

            // ЗАПОЛНЯЕМ КАРТОЧКУ ПРОДУКТА
            newProducts.CreateNewProductsName(product);
            newProducts.SelectNewCategoryId(product);
            newProducts.SelectNewSupplierId(product);
            newProducts.SendKeyNewUnitPrice(product);
            newProducts.SendKeyNewQuantityPerUnit(product);
            newProducts.SendKeyNewUnitsInStock(product);
            newProducts.SendKeyNewUnitsOnOrder(product); 
            newProducts.SendKeyNewReorderLevel(product); // +отмечаем скидку и нажимаем кнопку "Отправить"
        }

    }
}

