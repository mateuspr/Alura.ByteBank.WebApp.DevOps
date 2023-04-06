using OpenQA.Selenium.Firefox;
using System.IO;
using System.Reflection;
using Xunit;

namespace Alura.ByteBank.WebApp.Testes
{
    public class FirefoxTestes
    {
        [Fact]
        public void AcessandoPaginaDaMusicDot()
        {
            //Arrange
            var options = new FirefoxOptions()
            {
                //IntroduceInstabilityByIgnoringProtectedModeSettings = true,
                //IgnoreZoomLevel = true,
                //EnableNativeEvents = false,
               
                
            };
            var driver = new FirefoxDriver(Path.GetDirectoryName(
                Assembly.GetExecutingAssembly().Location), options);

            //Act
            driver.Navigate().GoToUrl("https://www.musicdot.com.br/");

            //Assert
            Assert.Contains("Music", driver.Title);

        }
    }
}
