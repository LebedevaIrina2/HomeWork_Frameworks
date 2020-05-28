using Frameworks.business_object;
using OpenQA.Selenium;
using PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Frameworks.service.ui
{
    class LoginService
    {
        
        public static void Autorization(LoginValue loginValue, IWebDriver driver)
        {
            MainPage mainPage = new MainPage(driver);    //инициализируем страницу MainPage
            Login login = new Login(driver);
            
            mainPage.LoginEnter(loginValue);  // вызываем метод ввода логина
            login = mainPage.PasswordAndAutorization(loginValue); // вызываем метод ввода пароля и клика по кнопке "Отправить". Переход на стр.Login

        }


    }


   
}
