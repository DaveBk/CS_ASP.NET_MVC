using DOT_Ksiega_gosci.Controllers;
using DOT_Ksiega_gosci;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Compatibility;
using System.Web.Mvc;

namespace DOT.Tests
{
    [TestFixture]
    public class HomeControllerTest
    {
        [Test]
        public void View_Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [Test]
        public void View_Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
