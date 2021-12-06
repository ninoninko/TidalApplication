using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TidalApplication
{
    internal class ProgramCases
    {
        /// <summary>
        /// The following method makes a call to the "Representation"
        /// methods of each of the objects in the two lists.
        /// </summary>
        /// <param name="songs"> is the list of songs </param>
        /// <param name="advertisements"> is the lsit of advertisements </param>
        public static void RepresentLists(List<Song> songs, List<Ads> advertisements)
        {
            List<Object> toPrint = new List<Object>();

            int keeper = 0;

            for (int i = 0; i < songs.Count; i++)
            {
                toPrint.Add(songs.ElementAt(i));
                if (keeper < advertisements.Count)
                {
                    toPrint.Add(advertisements.ElementAt(i));
                    keeper++;
                } else
                {
                    keeper = 0;
                    toPrint.Add(advertisements.ElementAt(i));
                }
            }

            int currentSong = 1;

            foreach (Object element in toPrint)
            {
                if (element.GetType() == typeof(Song))
                {
                    Song song = (Song)element;
                    Console.WriteLine(song.Representate(currentSong));
                    currentSong++;
                }

                if (element.GetType() == typeof(Ads))
                {
                    Ads ads = (Ads)element;
                    Console.WriteLine(ads.Representate());
                }
            }            
        }
    }
}
