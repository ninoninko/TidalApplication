using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TidalApplication
{
    internal class Album
    {
        private string _nameOfArtist;
        private string _nameOfAlbum;
        private string _yearOfRelease;

        /// <summary>
        /// Class constructor: initializes the class's attributes
        /// </summary>
        /// <param name="nameOfArtist"> is the name of the producer </param>
        /// <param name="nameOfAlbum"> is the title of the album </param>
        /// <param name="yearOfRelease"> is the year in which the album was released </param>
        public Album(string nameOfArtist, string nameOfAlbum, string yearOfRelease)
        {
            this._nameOfArtist = nameOfArtist;
            this._nameOfAlbum = nameOfAlbum;
            this._yearOfRelease = yearOfRelease;
        }

        /// <summary>
        /// Setter for the name of the producer
        /// </summary>
        /// <param name="nameOfArtist"> name of the producer </param>
        public void SetNameOfArtist(string nameOfArtist)
        {
            this._nameOfArtist = nameOfArtist;
        }

        /// <summary>
        /// Getter for the name of the producer
        /// </summary>
        /// <returns> the name of the producer </returns>
        public string GetNameOfArtist()
        {
            return _nameOfArtist;
        }

        /// <summary>
        /// Setter for the name of the album
        /// </summary>
        /// <param name="nameOfArtist"> name of the album </param>
        public void SetNameOfAlbum(string nameOfAlbum)
        {
            this._nameOfAlbum = nameOfAlbum;
        }

        /// <summary>
        /// Getter for the name of the album
        /// </summary>
        /// <returns> the name of the album </returns>
        public string GetNameOfAlbum()
        {
            return _nameOfAlbum;
        }

        /// <summary>
        /// Setter for the year of release
        /// </summary>
        /// <param name="nameOfArtist"> year of album release </param>
        public void SetYearOfRelease(string yearOfRelease)
        {
            this._yearOfRelease = yearOfRelease;
        }

        /// <summary>
        /// Getter for the year of release
        /// </summary>
        /// <returns> the year of release </returns>
        public string GetYearOfRelease()
        {
            return _yearOfRelease;
        }
    }
}
