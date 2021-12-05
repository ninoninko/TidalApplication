using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TidalApplication
{
    internal class Ads
    {
        
        private string _adAndType;
        private string _adAndDuration;

        /// <summary>
        /// Class constructor: initializes
        /// the class's attributes
        /// </summary>
        /// <param name="adAndType"> is the ad provider </param>
        /// <param name="adAndDuration"> is the duration of the ad </param>
        public Ads(string adAndType, string adAndDuration)
        {
            this._adAndType = adAndType;
            this._adAndDuration = adAndDuration;
        }

        /// <summary>
        /// Sets the value of the ad provider attribute
        /// </summary>
        /// <param name="adAndType"> is the provider of the ad </param>
        public void SetAdAndType (string adAndType)
        {
            this._adAndType = adAndType;
        }

        /// <summary>
        /// Getter for the ad provider
        /// </summary>
        /// <returns> the provider </returns>
        public string GetAdAndType()
        {
            return _adAndType;
        }

        /// <summary>
        /// Sets the duration of an ad
        /// </summary>
        /// <param name="adAndDuration"> is the duration of the ad </param>
        public void SetAdAndDuration(string adAndDuration)
        {
            this._adAndDuration = adAndDuration;
        }

        /// <summary>
        /// Getter for the duration of the ad
        /// </summary>
        /// <returns> the duration </returns>
        public string GetAdAndDuration()
        {
            return _adAndDuration;
        }


    }
}
