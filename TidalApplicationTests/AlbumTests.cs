using TidalApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.CompilerServices;

namespace TidalApplicationTests
{
    [TestClass]
    public class AlbumTests
    {
        /// <summary>
        /// The foolowing text checks whether the
        /// constructor and GetArtistMethods work properly
        /// </summary>
        [TestMethod]
        public void GetNameArtistWithStringTest()
        {
            // Arrange
            Album album = new Album("Virgo", "Deva", "2000");

            // Assert
            Assert.IsTrue(album.GetNameOfArtist().Equals("Virgo"));
        }

        /// <summary>
        /// The foolowing text checks whether the
        /// constructor and GetArtist methods work properly
        /// </summary>
        [TestMethod]
        public void GetNameArtistEmptyStringTest()
        {
            // Arrange
            Album album = new Album("", "Deva", "2000");

            // Assert
            Assert.IsTrue(album.GetNameOfArtist().Equals(""));
        }

        /// <summary>
        /// The foolowing text checks whether the
        /// constructor and GetAlbumName methods work properly
        /// </summary>
        [TestMethod]
        public void GetNameAlbumWithStringTest()
        {
            // Arrange
            Album album = new Album("Virgo", "Deva", "2000");

            // Assert
            Assert.IsTrue(album.GetNameOfAlbum().Equals("Deva"));
        }

        /// <summary>
        /// The foolowing text checks whether the
        /// constructor and GetAlbumName methods work properly
        /// </summary>
        [TestMethod]
        public void GetNameAlbumEmptyStringTest()
        {
            // Arrange
            Album album = new Album("Virgo", "", "2000");

            // Assert
            Assert.IsTrue(album.GetNameOfAlbum().Equals(""));
        }

        /// <summary>
        /// The foolowing text checks whether the
        /// constructor and GetProductionYear methods work properly
        /// </summary>
        [TestMethod]
        public void GetProductionYearWithStringTest()
        {
            // Arrange
            Album album = new Album("Virgo", "Deva", "");

            // Assert
            Assert.IsTrue(album.GetYearOfRelease().Equals(""));
        }

        /// <summary>
        /// The foolowing text checks whether the
        /// constructor and GetProductionYear methods work properly
        /// </summary>
        [TestMethod]
        public void GetProductionYearEmptyStringTest()
        {
            // Arrange
            Album album = new Album("", "Deva", "");

            // Assert
            Assert.IsTrue(album.GetYearOfRelease().Equals(""));
        }

        /// <summary>
        /// The foolowing text checks whether the
        /// constructor, SetArtistName and GetArtistMethods work properly
        /// </summary>
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

        /// <summary>
        /// The foolowing text checks whether the
        /// constructor, SetArtistName and 
        /// GetArtistMethods work properly
        /// </summary>
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

        /// <summary>
        /// The foolowing text checks whether the
        /// constructor, SetAlbumName and 
        /// GetAlbumMethods work properly
        /// </summary>
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

        /// <summary>
        /// The foolowing text checks whether the
        /// constructor, SetAlbumName and 
        /// GetAlbumMethods work properly
        /// </summary>
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

        /// <summary>
        /// The foolowing text checks whether the
        /// constructor, SetProductionYear and 
        /// GetProductionYear work properly
        /// </summary>
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

        /// <summary>
        /// The foolowing text checks whether the
        /// constructor, SetProductionYear and 
        /// GetProductionYear work properly
        /// </summary>
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

        /// <summary>
        /// The following methods checks whether
        /// the Representation method works properly
        /// under some manipulations of the class's attributes.
        /// </summary>
        [TestMethod]
        public void RepresentateAllStringsTest()
        {
            // Arrange
            Album album = new Album("Virgo", "Deva", "2000");

            // Assert
            Assert.IsTrue(album.Representate().Equals("Album: Virgo's Deva from 2000."));
        }

        /// <summary>
        /// The following methods checks whether
        /// the Representation method works properly
        /// under some manipulations of the class's attributes.
        /// </summary>
        [TestMethod]
        public void RepresentateSomeStringsFirstTest()
        {
            // Arrange
            Album album = new Album("", "Deva", "2000");

            // Assert
            Assert.IsTrue(album.Representate().Equals("Album: 's Deva from 2000."));
        }

        /// <summary>
        /// The following methods checks whether
        /// the Representation method works properly
        /// under some manipulations of the class's attributes.
        /// </summary>
        [TestMethod]
        public void RepresentateSomeStringsSecondTest()
        {
            // Arrange
            Album album = new Album("Virgo", "", "2000");

            // Assert
            Assert.IsTrue(album.Representate().Equals("Album: Virgo's  from 2000."));
        }

        /// <summary>
        /// The following methods checks whether
        /// the Representation method works properly
        /// under some manipulations of the class's attributes.
        /// </summary>
        [TestMethod]
        public void RepresentateSomeStringsThirdTest()
        {
            // Arrange
            Album album = new Album("Virgo", "", "");

            // Assert
            Assert.IsTrue(album.Representate().Equals("Album: Virgo's  from ."));
        }

        /// <summary>
        /// The following methods checks whether
        /// the Representation method works properly
        /// under some manipulations of the class's attributes.
        /// </summary>
        [TestMethod]
        public void RepresentateSomeStringsOneAndThreeTest()
        {
            // Arrange
            Album album = new Album("", "Virgo", "");

            // Assert
            Assert.IsTrue(album.Representate().Equals("Album: 's Virgo from ."));
        }

        /// <summary>
        /// The following methods checks whether
        /// the Representation method works properly
        /// under some manipulations of the class's attributes.
        /// </summary>
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

        /// <summary>
        /// The following method checks
        /// whether the class's attributes can be 
        /// represented back in the file format
        /// </summary>
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
