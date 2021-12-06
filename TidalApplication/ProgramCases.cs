using System;
using System.Collections.Generic;
using System.IO;
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
                }
                else
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

        /// <summary>
        /// The following method is a control method.
        /// It checks whether a new album has to be made
        /// and depending on the answer it goes to another method.
        /// </summary>
        /// <param name="songs"> is the list of songs </param>
        /// <param name="advertisements"> is the list of advertisements </param>
        public static void WriteToFiles(List<Song> songs, List<Ads> advertisements)
        {
            Console.WriteLine("Dear user, you have decided to add additional tracks to your albums." +
                "\nIn which album have you decided to add new tracks?");

            List<string> availableAlbums = ControlClass.getListCDs();
            Console.WriteLine("Dear user, here are your available albums: ");
            foreach (string album in availableAlbums)
            {
                Console.WriteLine(album);
            }

            string chosenAlbums = Console.ReadLine();
         
            while (chosenAlbums.Length == 0)
            {
                Console.Write("Dear user, the album name should have at least 1 letter." +
                    "\nPlease, try again: ");
                chosenAlbums = Console.ReadLine();
            }

            bool newAlbum = false;

            while (!availableAlbums.Contains(chosenAlbums + ".txt"))
            {
                Console.Write("Dear user, the album name which you have chosen" +
                    "\nis not from the list from above. Do you wish to add a new album?" +
                    "\nType in 'n' not to create a new album or press any" +
                    "\nother key to create a new one: ");

                string decision = Console.ReadLine();

                if (decision.Equals("n"))
                {
                    chosenAlbums = Console.ReadLine();
                }
                else
                {
                    newAlbum = true;
                    break;
                }
            }

            if (newAlbum == false)
            {
                dontCreateAlbum(chosenAlbums, songs, advertisements);
            }


        }

        /// <summary>
        /// The following method add the new musical file to the list of files
        /// </summary>
        /// <param name="userChoiceAlbum"> is the album in which the file is going to be added </param>
        /// <param name="songs"> is the list of songs </param>
        /// <param name="advertisements"> is the list of ads </param>
        public static void dontCreateAlbum(string userChoiceAlbum, List<Song> songs, List<Ads> advertisements)
        {
            Console.WriteLine("Dear user, what is the name of the song?");

            String answerFirst = Console.ReadLine();

            Console.WriteLine("Dear user, what is the duration of the song?" +
                "\nWrite it in this format '0:00'");
            String answerSecond = Console.ReadLine();

            Song newSong = new Song(songs.ElementAt(0).GetNameOfArtist(), 
                songs.ElementAt(0).GetNameOfAlbum(), 
                songs.ElementAt(0).GetYearOfRelease(),
                (songs.Count - 1).ToString(), answerFirst, answerSecond);

            // Add the new song to the list
            songs.Add(newSong);

            try
            {
                using StreamWriter file = new StreamWriter
                    (@"D:\C#\TidalProject\TidalApplication\TidalApplication\" + userChoiceAlbum + ".txt", false);
                {
                    file.WriteLine("CDS");
                    file.WriteLine(songs.ElementAt(0).ToString());
                    foreach (Song song in songs)
                    {
                        file.WriteLine(song.ToString());
                    }
                    file.WriteLine("ADDS");
                    foreach (Ads ad in advertisements)
                    {
                        file.WriteLine(ad.ToString());
                    }

                    file.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No idea what happened here");
            }

        }
    }
}
