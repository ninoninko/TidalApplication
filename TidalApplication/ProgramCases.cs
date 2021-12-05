using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TidalApplication
{
    internal class ProgramCases
    {
        public static void RepresentLists(List<Song> songs, List<Ads> advertisements)
        {
            List<Object> toPrint = new List<Object>();

            for (int i = 0; i < songs.Count; i++)
            {
                toPrint.Add(songs.ElementAt(i));
                toPrint.Add(advertisements.ElementAt(i));
            }

            int currentSong = 1;

            foreach (Object element in toPrint)
            {
                if (element.GetType() == typeof(Song))
                {
                    Song song = (Song)element;
                    song.Representate(currentSong);
                    currentSong++;
                }

                if (element.GetType() == typeof(Ads))
                {
                    Ads ads = (Ads)element;
                    ads.Representate();
                }
            }

            
        }
    }
}
