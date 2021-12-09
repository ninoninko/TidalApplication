using TidalApplication;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.CompilerServices;

namespace TidalApplicationTests
{
    [TestClass]
    public class SongsTests
    {

        /// <summary>
        /// The following unit test checks
        /// whether the constructor and getter
        /// for the number of the track
        /// </summary>
        [TestMethod]
        public void SongGetTrackNumberTextTest()
        {
            // Arrange
            Song song = new Song("Virgo", "Balkanika", "2000", "1", "Deva", "2:12");

            // Assert
            Assert.IsTrue(song.GetTrackNumber().Equals("1"));
        }

        /// <summary>
        /// The following unit test checks
        /// whether the constructor and getter
        /// for the number of the track
        /// </summary>
        [TestMethod]
        public void SongGetTrackNumberNoTextTest()
        {
            // Arrange
            Song song = new Song("Virgo", "Balkanika", "2000", "", "Deva", "2:12");

            // Assert
            Assert.IsTrue(song.GetTrackNumber().Equals(""));
        }

        /// <summary>
        /// The following unit test checks
        /// whether the constructor and getter
        /// for the name of the track
        /// </summary>
        [TestMethod]
        public void SongGetTrackNameTextTest()
        {
            // Arrange
            Song song = new Song("Virgo", "Balkanika", "2000", "1", "Deva", "2:12");

            // Assert
            Assert.IsTrue(song.GetTrackName().Equals("Deva"));
        }

        /// <summary>
        /// The following unit test checks
        /// whether the constructor and getter
        /// for the name of the track
        /// </summary>
        [TestMethod]
        public void SongGetTrackNameEmptyTest()
        {
            // Arrange
            Song song = new Song("Virgo", "Balkanika", "2000", "1", "", "2:12");

            // Assert
            Assert.IsTrue(song.GetTrackName().Equals(""));
        }

        /// <summary>
        /// The following unit test checks
        /// whether the constructor and getter
        /// for the duration of the track
        /// </summary>
        [TestMethod]
        public void SongGetTrackDurationEmpryTest()
        {
            // Arrange
            Song song = new Song("Virgo", "Balkanika", "2000", "1", "", "");

            // Assert
            Assert.IsTrue(song.GetTrackDuration().Equals(""));
        }

        /// <summary>
        /// The following unit test checks
        /// whether the constructor and getter
        /// for the duration of the track
        /// </summary>
        [TestMethod]
        public void SongGetTrackDurationTest()
        {
            // Arrange
            Song song = new Song("Virgo", "Balkanika", "2000", "1", "", "1:12");

            // Assert
            Assert.IsTrue(song.GetTrackDuration().Equals("1:12"));
        }

        /// <summary>
        /// The following unit test checks
        /// whether the constructor and getter
        /// for the number of the track
        /// </summary>
        [TestMethod]
        public void SongSetTrackNumberTextTest()
        {
            // Arrange
            Song song = new Song("Virgo", "Balkanika", "2000", "1", "Deva", "2:12");

            // Act
            song.SetTrackNumber("2");

            // Assert
            Assert.IsTrue(song.GetTrackNumber().Equals("2"));
        }

        /// <summary>
        /// The following unit test checks
        /// whether the constructor and getter
        /// for the number of the track
        /// </summary>
        [TestMethod]
        public void SongSetTrackNumberEmptyTest()
        {
            // Arrange
            Song song = new Song("Virgo", "Balkanika", "2000", "1", "Deva", "2:12");

            // Act
            song.SetTrackNumber("");

            // Assert
            Assert.IsTrue(song.GetTrackNumber().Equals(""));
        }

        /// <summary>
        /// The following unit test checks
        /// whether the constructor and getter
        /// for the name of the track
        /// </summary>
        [TestMethod]
        public void SongSetTrackNameTextTest()
        {
            // Arrange
            Song song = new Song("Virgo", "Balkanika", "2000", "1", "Deva", "2:12");

            // Act
            song.SetTrackName("Strelec");

            // Assert
            Assert.IsTrue(song.GetTrackName().Equals("Strelec"));
        }

        /// <summary>
        /// The following unit test checks
        /// whether the constructor and getter
        /// for the name of the track
        /// </summary>
        [TestMethod]
        public void SongSetTrackNameEmptyTest()
        {
            // Arrange
            Song song = new Song("Virgo", "Balkanika", "2000", "1", "Deva", "2:12");

            // Act
            song.SetTrackName("");

            // Assert
            Assert.IsTrue(song.GetTrackName().Equals(""));
        }

        /// <summary>
        /// The following unit test checks
        /// whether the constructor and getter
        /// for the duration of the track
        /// </summary>
        [TestMethod]
        public void SongSetTrackDurationTextTest()
        {
            // Arrange
            Song song = new Song("Virgo", "Balkanika", "2000", "1", "Deva", "2:12");

            // Act
            song.SetTrackDuration("3:10");

            // Assert
            Assert.IsTrue(song.GetTrackDuration().Equals("3:10"));
        }

        /// <summary>
        /// The following unit test checks
        /// whether the constructor and getter
        /// for the name of the track
        /// </summary>
        [TestMethod]
        public void SongSetTrackDurationEmptyTest()
        {
            // Arrange
            Song song = new Song("Virgo", "Balkanika", "2000", "1", "Deva", "2:12");

            // Act
            song.SetTrackDuration("");

            // Assert
            Assert.IsTrue(song.GetTrackDuration().Equals(""));
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
            Song song = new Song("CD Virgo", "Deva", "2021", "SONG 1", "Space-out", "2:54");

            // Assert
            Assert.IsTrue(song.Representate(1).Equals("Album:  Virgo's Deva from 2021.Track Space-out (2:54)"));
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
            Song song = new Song("CD Virgo", "Deva", "2021", "", "Space-out", "2:54");

            // Assert
            Assert.IsTrue(song.Representate(1).Equals("Album:  Virgo's Deva from 2021.Track Space-out (2:54)"));
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
            Song song = new Song("CD Virgo", "Deva", "2021", "", "", "2:54");

            // Assert
            Assert.IsTrue(song.Representate(1).Equals("Album:  Virgo's Deva from 2021.Track  (2:54)"));
        }

        /// <summary>
        /// The following method tests whether the 
        /// Representation method presents the code
        /// in the needed way
        /// </summary>
        [TestMethod]
        public void RepresentateStringThirdTest()
        {
            // Arrange
            Song song = new Song("CD Virgo", "Deva", "2021", "", "Hasta", "");

            // Assert
            Assert.IsTrue(song.Representate(1).Equals("Album:  Virgo's Deva from 2021.Track Hasta ()"));
        }

        /// <summary>
        /// The following method tests whether the 
        /// Representation method presents the code
        /// in the needed way
        /// </summary>
        [TestMethod]
        public void RepresentateStringEmptyTest()
        {
            // Arrange
            Song song = new Song("CD Virgo", "Deva", "2021", "", "", "");

            // Assert
            Assert.IsTrue(song.Representate(1).Equals("Album:  Virgo's Deva from 2021.Track  ()"));
        }

        /// <summary>
        /// The following method checks whether 
        /// the Song's class attributes are 
        /// presented in the right way
        /// </summary>
        [TestMethod]
        public void ToStringTest()
        {
            // Arrange
            Song song = new Song("", "", "", "SONG 1", "Marsel", "1:11");

            // Assert
            Assert.IsTrue(song.ToString().Equals("SONG 1, Marsel, 1:11"));
        }

        /// <summary>
        /// The following method checks whether 
        /// the Song's class attributes are 
        /// presented in the right way
        /// </summary>
        [TestMethod]
        public void ToStringTestAlbum()
        {
            // Arrange
            Album song = new Album("CD YANAKI", "MISERY", "2021");

            // Assert
            Assert.IsTrue(song.ToString().Equals("CD YANAKI, MISERY, 2021"));
        }
    }
}
