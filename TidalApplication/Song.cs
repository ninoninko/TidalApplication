using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("TidalApplicationTests")]

namespace TidalApplication
{
    internal class Song : Album
    {
        private string _trackNumber;
        private string _trackName;
        private string _trackDuration;

        /// <summary>
        /// Class constructor: initializes the class's attributes
        /// </summary>
        /// <param name="nameOfArtist"> is the name of the producer </param>
        /// <param name="nameOfAlbum"> is the name of the album </param>
        /// <param name="yearOfRelease"> is the year of release </param>
        /// <param name="trackNumber"> is the number of the track </param>
        /// <param name="trackName"> is the name of the track </param>
        /// <param name="trackDuration"> is the duration of the track</param>
        public Song(string nameOfArtist, string nameOfAlbum, string yearOfRelease, 
            string trackNumber, string trackName, string trackDuration) : base(nameOfArtist, nameOfAlbum, yearOfRelease)
        {
            this._trackNumber = trackNumber;
            this._trackName = trackName;
            this._trackDuration = trackDuration;   
        }

        /// <summary>
        /// Set the number of the track
        /// </summary>
        /// <param name="trackNumber"> is the number of the track </param>
        public void SetTrackNumber(string trackNumber)
        {
            this._trackNumber = trackNumber;
        }

        /// <summary>
        /// Getter for the number of the track
        /// </summary>
        /// <returns> the number of the track </returns>
        public string GetTrackNumber()
        {
            return _trackNumber;
        }

        /// <summary>
        /// Set the name of the track
        /// </summary>
        /// <param name="trackNa,e"> is the name of the track </param>
        public void SetTrackName(string trackName)
        {
            this._trackName = trackName;
        }

        /// <summary>
        /// Getter for the name of the track
        /// </summary>
        /// <returns> the name of the track </returns>
        public string GetTrackName()
        {
            return _trackName;
        }

        /// <summary>
        /// Set the duration of the track
        /// </summary>
        /// <param name="trackDuration"> is the number of the track</param>
        public void SetTrackDuration(string trackDuration)
        {
            this._trackDuration = trackDuration;
        }

        /// <summary>
        /// Getter for the duration of the track
        /// </summary>
        /// <returns> the duration of the track </returns>
        public string GetTrackDuration()
        {
            return _trackDuration;
        }

        /// <summary>
        /// The following method represents the class's
        /// attributes in a human - friendly way
        /// </summary>
        public string Representate(int current)
        {
            
            return (base.Representate() + "Track " + _trackName.Replace("SONG " + current, "")
                + " (" + _trackDuration +")");
        }

    }
}
