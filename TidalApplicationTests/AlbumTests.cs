using TidalApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.CompilerServices;

namespace TidalApplicationTests
{
    [TestClass]
    public class AlbumTests
    {
        [TestMethod]
        public void GetNameArtistWithStringTest()
        {
            // Arrange
            Album album = new Album("Virgo", "Deva", "2000");

            // Assert
            Assert.IsTrue(album.GetNameOfArtist().Equals("Virgo"));
        }

        [TestMethod]
        public void GetNameArtistEmptyStringTest()
        {
            // Arrange
            Album album = new Album("", "Deva", "2000");

            // Assert
            Assert.IsTrue(album.GetNameOfArtist().Equals(""));
        }

        [TestMethod]
        public void GetNameAlbumWithStringTest()
        {
            // Arrange
            Album album = new Album("Virgo", "Deva", "2000");

            // Assert
            Assert.IsTrue(album.GetNameOfAlbum().Equals("Deva"));
        }

        [TestMethod]
        public void GetNameAlbumEmptyStringTest()
        {
            // Arrange
            Album album = new Album("Virgo", "", "2000");

            // Assert
            Assert.IsTrue(album.GetNameOfAlbum().Equals(""));
        }

        [TestMethod]
        public void GetProductionYearWithStringTest()
        {
            // Arrange
            Album album = new Album("Virgo", "Deva", "");

            // Assert
            Assert.IsTrue(album.GetYearOfRelease().Equals(""));
        }

        [TestMethod]
        public void GetProductionYearEmptyStringTest()
        {
            // Arrange
            Album album = new Album("", "Deva", "");

            // Assert
            Assert.IsTrue(album.GetYearOfRelease().Equals(""));
        }

        [TestMethod]
        public void SetNameArtistWithStringTest()
        {
            // Arrange
            Album album = new Album("Virgo", "Deva", "2000");

            // Act
            album.SetNameOfArtist("TRF");

            // Assert
            Assert.IsTrue(album.GetNameOfArtist().Equals("TRF"));
        }

        [TestMethod]
        public void SetNameArtistEmptyStringTest()
        {
            // Arrange
            Album album = new Album("Virgo", "Deva", "2000");

            // Act
            album.SetNameOfArtist("");

            // Assert
            Assert.IsTrue(album.GetNameOfArtist().Equals(""));
        }

        [TestMethod]
        public void SetNameAlbumWithStringTest()
        {
            // Arrange
            Album album = new Album("Virgo", "Deva", "2000");

            // Act
            album.SetNameOfAlbum("TRF");

            // Assert
            Assert.IsTrue(album.GetNameOfAlbum().Equals("TRF"));
        }

        [TestMethod]
        public void SetNameAlbumEmptyStringTest()
        {
            // Arrange
            Album album = new Album("Virgo", "TRF", "2000");

            // Act
            album.SetNameOfAlbum("");

            // Assert
            Assert.IsTrue(album.GetNameOfAlbum().Equals(""));
        }

        [TestMethod]
        public void SetProductionYearWithStringTest()
        {
            // Arrange
            Album album = new Album("Virgo", "Deva", "2010");

            // Act
            album.SetYearOfRelease("2000");

            // Assert
            Assert.IsTrue(album.GetYearOfRelease().Equals("2000"));
        }

        [TestMethod]
        public void SetProductionYearEmptyStringTest()
        {
            // Arrange
            Album album = new Album("", "Deva", "2000");

            // Act
            album.SetYearOfRelease("");

            // Assert
            Assert.IsTrue(album.GetYearOfRelease().Equals(""));
        }

        [TestMethod]
        public void RepresentateAllStringsTest()
        {
            // Arrange
            Album album = new Album("Virgo", "Deva", "2000");

            // Assert
            Assert.IsTrue(album.Representate().Equals("Album: Virgo's Deva from 2000."));
        }

        [TestMethod]
        public void RepresentateSomeStringsFirstTest()
        {
            // Arrange
            Album album = new Album("", "Deva", "2000");

            // Assert
            Assert.IsTrue(album.Representate().Equals("Album: 's Deva from 2000."));
        }

        [TestMethod]
        public void RepresentateSomeStringsSecondTest()
        {
            // Arrange
            Album album = new Album("Virgo", "", "2000");

            // Assert
            Assert.IsTrue(album.Representate().Equals("Album: Virgo's  from 2000."));
        }

        [TestMethod]
        public void RepresentateSomeStringsThirdTest()
        {
            // Arrange
            Album album = new Album("Virgo", "", "");

            // Assert
            Assert.IsTrue(album.Representate().Equals("Album: Virgo's  from ."));
        }

        [TestMethod]
        public void RepresentateSomeStringsOneAndThreeTest()
        {
            // Arrange
            Album album = new Album("", "Virgo", "");

            // Assert
            Assert.IsTrue(album.Representate().Equals("Album: 's Virgo from ."));
        }

        [TestMethod]
        public void RepresentateSomeStringsSetTest()
        {
            // Arrange
            Album album = new Album("", "Virgo", "");

            // Act
            album.SetYearOfRelease("2005");
            album.SetNameOfArtist("Kristo");
            album.SetNameOfAlbum("");
            album.SetNameOfArtist("Krisko");

            // Assert
            Assert.IsTrue(album.Representate().Equals("Album: Krisko's  from 2005."));
        }

        [TestMethod]
        public void ToStringAllStringsTest()
        {
            // Arrange
            Album album = new Album("CD Virgo", "Deva", "2000");

            // Assert
            Assert.IsTrue(album.ToStringSuper().Equals("CD Virgo, Deva, 2000"));
        }
    }
}
