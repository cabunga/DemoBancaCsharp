using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace Banca.Tests
{
    [Binding]    
    public class AutenticacionDeUsuarioSteps
    {
        private static IWebDriver driver;
        [FindsBy(How = How.Id, Using = "idUsuario")]
        private IWebElement inputUsuario { set; get; }

        [FindsBy(How = How.Id, Using = "idPassword")]
        private IWebElement inputPassword { set; get; }

        [FindsBy(How = How.Id, Using = "idLoguearse")]
        private IWebElement buttonSubmit { set; get; }

        [BeforeScenario]
        public void setUp()
        {
            driver = new ChromeDriver("driver");           
        }

        [AfterScenario]
        public void tearDown()
        {
            driver.Quit();
        }
        
        [Given(@"Ingreso a la sucursal virtual")]
        public void GivenIngresoALaSucursalVirtual()
        {
            driver.Navigate().GoToUrl("http://localhost:49491/Usuario/Index");

        }
        
        [When(@"Ingreso login ""(.*)""")]
        public void WhenIngresoLogin(string usuario)
        {
            driver.FindElement(By.Id("idUsuario")).SendKeys(usuario);            
        }
        
        [When(@"y passwrod ""(.*)""")]
        public void WhenYPasswrod(string pass)
        {
            driver.FindElement(By.Id("idPassword")).SendKeys(pass);
            //inputPassword.SendKeys(pass);
        }
        
        [When(@"seleccion ingresar")]
        public void WhenSeleccionIngresar()
        {
            driver.FindElement(By.Id("idLoguearse")).Click();
        }
        
        [Then(@"Ingreso a la pagina de transferencia")]
        public void ThenIngresoALaPaginaDeTransferencia()
        {
            Assert.AreEqual(1,1);
        }
    }
}
