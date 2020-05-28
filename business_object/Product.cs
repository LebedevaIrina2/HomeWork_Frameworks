using System;
using System.Collections.Generic;
using System.Text;

namespace Frameworks.business_object
{
    class Product
    {      
       // Данные для заполнения карточки "Новый продукт"
        public string SendKeysProductName { get; set; }
        public string SelectCategoryId { get; set; }
        public string SelectSupplierId { get; set; }
        public string SendKeysUnitPrice { get; set; }      
        public string SendKeysQuantityPerUnit { get; set; }
        public string SendKeysUnitsInStock { get; set; }
        public string SendKeysUnitsOnOrder { get; set; }
        public string SendKeysReorderLevel { get; set; }
        public string SelectDiscontinuedl { get; set; }



        public Product(
            string SendKeysProductName,
            string SelectCategoryId,
            string SelectSupplierId,
            string SendKeysUnitPrice,            
            string SendKeysQuantityPerUnit,
            string SendKeysUnitsInStock,
            string SendKeysUnitsOnOrder,
            string SendKeysReorderLevel,
            string SelectDiscontinuedl
            )
        {
           this.SendKeysProductName = SendKeysProductName;
           this.SelectCategoryId=SelectCategoryId;
           this.SelectSupplierId=SelectSupplierId;
           this.SendKeysUnitPrice= SendKeysUnitPrice;           
           this.SendKeysQuantityPerUnit=SendKeysQuantityPerUnit;
           this.SendKeysUnitsInStock=SendKeysUnitsInStock;
           this.SendKeysUnitsOnOrder= SendKeysUnitsOnOrder;
           this.SendKeysReorderLevel = SendKeysReorderLevel;
           this.SelectDiscontinuedl = SelectDiscontinuedl;
        }

    }
}

