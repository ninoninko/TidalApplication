using TidalApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.CompilerServices;

namespace TidalApplicationTests
{
    [TestClass]
    public class AdsTests
    {
        /// <summary>
        /// The following unit test checks
        /// whether the constructor and getter
        /// for the type of the ad work
        /// </summary>
        [TestMethod]
        public void AdsGetProviderStringTest()
        {
            // Arrange
            Ads ads = new Ads("ING DSK", "0:12");

            // Assert
            Assert.IsTrue(ads.GetAdAndType().Equals("ING DSK"));
        }

        /// <summary>
        /// The following unit test checks
        /// whether the constructor and getter
        /// for the type of the ad work
        /// </summary>
        [TestMethod]
        public void AdsGetProviderEmptyTest()
        {
            // Arrange
            Ads ads = new Ads("", "0:12");

            // Assert
            Assert.IsTrue(ads.GetAdAndType().Equals(""));
        }

        /// <summary>
        /// The following unit test checks
        /// whether the constructor and getter
        /// for the duration of the ad work
        /// </summary>
        [TestMethod]
        public void AdsGetDurationStringTest()
        {
            // Arrange
            Ads ads = new Ads("ING DSK", "0:12");

            // Assert
            Assert.IsTrue(ads.GetAdAndDuration().Equals("0:12"));
        }

        /// <summary>
        /// The following unit test checks
        /// whether the constructor and getter
        /// for the duration of the ad work
        /// </summary>
        [TestMethod]
        public void AdsGetDurationEmptyTest()
        {
            // Arrange
            Ads ads = new Ads("ING DSK", "");

            // Assert
            Assert.IsTrue(ads.GetAdAndDuration().Equals(""));
        }

        /// <summary>
        /// The following method checks
        /// whether the setter for the 
        /// type of the add works
        /// </summary>
        [TestMethod]
        public void AdsSetProviderEmptyTest()
        {
            // Arrange
            Ads ads = new Ads("ING DSK", "0:12");

            // Act
            ads.SetAdAndType("");

            // Assert
            Assert.IsTrue(ads.GetAdAndType().Equals(""));
        }

        /// <summary>
        /// The following method checks
        /// whether the setter for the 
        /// type of the add works
        /// </summary>
        [TestMethod]
        public void AdsSetProviderStringTest()
        {
            // Arrange
            Ads ads = new Ads("ING DSK", "0:12");

            // Act
            ads.SetAdAndType("ING NEDERLAND");

            // Assert
            Assert.IsTrue(ads.GetAdAndType().Equals("ING NEDERLAND"));
        }

        /// <summary>
        /// The following method checks
        /// whether the setter for the 
        /// duration of the add works
        /// </summary>
        [TestMethod]
        public void AdsSetDurationStringTest()
        {
            // Arrange
            Ads ads = new Ads("ING DSK", "0:12");

            // Act
            ads.SetAdAndDuration("0:11");

            // Assert
            Assert.IsTrue(ads.GetAdAndDuration().Equals("0:11"));
        }

        /// <summary>
        /// The following method checks
        /// whether the setter for the 
        /// duration of the add works
        /// </summary>
        [TestMethod]
        public void AdsSetDurationEmptyTest()
        {
            // Arrange
            Ads ads = new Ads("ING DSK", "0:12");

            // Act
            ads.SetAdAndDuration("");

            // Assert
            Assert.IsTrue(ads.GetAdAndDuration().Equals(""));
        }

        /// <summary>
        /// The following method tests whether the 
        /// Representation method presents the code
        /// in the needed way
        /// </summary>
        [TestMethod]
        public void RepresentateStringTest()
        {
            // Arrange
            Ads ads = new Ads("ADD DSK", "0:12");

            // Assert
            Assert.IsTrue(ads.Representate().Equals("Next add: DSK(0:12)"));
        }

        /// <summary>
        /// The following method tests whether the 
        /// Representation method presents the code
        /// in the needed way
        /// </summary>
        [TestMethod]
        public void RepresentateStringFirstTest()
        {
            // Arrange
            Ads ads = new Ads("ADD DSK", "");

            // Assert
            Assert.IsTrue(ads.Representate().Equals("Next add: DSK()"));
        }

        /// <summary>
        /// The following method tests whether the 
        /// Representation method presents the code
        /// in the needed way
        /// </summary>
        [TestMethod]
        public void RepresentateStringSecondTest()
        {
            // Arrange
            Ads ads = new Ads("", "0:12");

            // Assert
            Assert.IsTrue(ads.Representate().Equals("Next add: (0:12)"));
        }

        /// <summary>
        /// The following method tests whether the 
        /// Representation method presents the code
        /// in the needed way
        /// </summary>
        [TestMethod]
        public void RepresentateEmptyTest()
        {
            // Arrange
            Ads ads = new Ads("", "");

            // Assert
            Assert.IsTrue(ads.Representate().Equals("Next add: ()"));
        }

        /// <summary>
        /// The following method checks whether 
        /// the Ads' class attributes are 
        /// presented in the right way
        /// </summary>
        [TestMethod]
        public void ToStringTest()
        {
            // Arrange
            Ads ads = new Ads("ADD DSK", "0:12");

            // Assert
            Assert.IsTrue(ads.ToString().Equals("ADD DSK, 0:12"));
        }
    }
}
