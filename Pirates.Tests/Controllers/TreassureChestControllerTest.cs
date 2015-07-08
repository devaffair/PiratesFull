using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pirates;
using Pirates.Controllers;

namespace Pirates.Tests.Controllers
{
    [TestClass]
    public class TreassureChestControllerTest
    {
        [TestMethod]
        public void GetCoins_0_Pirates()
        {
            int resVal = 0;
            TreassureChestController controller = new TreassureChestController();

            // Assert 0
            Assert.IsTrue(!int.TryParse(controller.Get("0"), out resVal));
        }
        [TestMethod]
        public void GetCoins_1_Pirates()
        {
            int resVal = 0;
            TreassureChestController controller = new TreassureChestController();
            // Assert 1
            Assert.IsTrue(!int.TryParse(controller.Get("1"), out resVal));
        }
        [TestMethod]
        public void GetCoins_2_Pirates()
        {
            TreassureChestController controller = new TreassureChestController();

            // Assert 2
            Assert.AreEqual("31", controller.Get("2"));
        }
        [TestMethod]
        public void GetCoins_5_Pirates()
        {
            TreassureChestController controller = new TreassureChestController();

            // Assert 5
            Assert.AreEqual("15621", controller.Get("5"));
        }
    }
}
