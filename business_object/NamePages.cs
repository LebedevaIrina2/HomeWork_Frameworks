using System;
using System.Collections.Generic;
using System.Text;

namespace Frameworks.business_object
{
    class NamePages
    {   
        // Данные для проверки загрузки верной страницы
        public string NameHomePage { get; set; }
        public string NameLoginPage { get; set; }
        public string NameProductEditingPage { get; set; }
        public string NameAllProductsgPage { get; set; }

        public NamePages(string NameHomePage, string NameLoginPage, string NameProductEditingPage, string NameAllProductsgPagef)
        {
            this.NameHomePage = NameHomePage;
            this.NameLoginPage = NameLoginPage;
            this.NameProductEditingPage = NameProductEditingPage;
            this.NameAllProductsgPage = NameAllProductsgPage;
        }
    }
}

