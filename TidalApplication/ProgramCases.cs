using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


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
            // Controls the adds which are added to the toPrint list
            int keeper = 0;

            // Add all objects from the Song list and Ads list to a new list of type Object
            for (int i = 0; i < songs.Count; i++)
            {
                toPrint.Add(songs.ElementAt(i));
                if (keeper < advertisements.Count)
                {
                    toPrint.Add(advertisements.ElementAt(keeper));
                    keeper++;
                }
                else
                {
                    keeper = 0;
                    toPrint.Add(advertisements.ElementAt(keeper));
                }
            }

            int currentSong = 1;

            // Print all of the information inside the toPrint list of objects
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

            // Get and print a list of all the available albums
            List<string> availableAlbums = ControlClass.getListCDs();
            Console.WriteLine("Dear user, here are your available albums: ");

            foreach (string album in availableAlbums)
            {
                Console.WriteLine(album.Replace(".txt", ""));
            }

            // User's choice
            string chosenAlbums = Console.ReadLine();
         
            while (chosenAlbums.Length == 0)
            {
                Console.Write("Dear user, the album name should have at least 1 letter." +
                    "\nPlease, try again: ");
                chosenAlbums = Console.ReadLine();
            }

            // Confirmation whether the user wants to create a new album
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
                    Console.Write("Dear user, please type in the name of the album: ");
                    chosenAlbums = Console.ReadLine();
                }
                else
                {
                    newAlbum = true;
                    break;
                }
            }
            
            DontCreateAlbum(chosenAlbums, songs, advertisements, newAlbum);
           
        }

        /// <summary>
        /// The following method add the new musical file to the list of files
        /// </summary>
        /// <param name="userChoiceAlbum"> is the album in which the file is going to be added </param>
        /// <param name="songs"> is the list of songs </param>
        /// <param name="advertisements"> is the list of ads </param>
        public static void DontCreateAlbum(string userChoiceAlbum, List<Song> songs, List<Ads> advertisements, bool newAlbum)
        {
            string albumProducer = "CD ";
            string albumName = "";
            string albumReleaseYear = "";

            // Change the values of the 3 strings above
            // should the user want to create a new album
            if (newAlbum == true)
            {
                songs = new List<Song>();
                advertisements = new List<Ads>();
                List<string> ads = ControlClass.getInfoAsList("AdditionalAds", 2);
                advertisements = ControlClass.getClassesFromListTracks(ads, 2);
                Console.WriteLine("Who is the producer of the album?");
                albumProducer = albumProducer + Console.ReadLine();
                Console.WriteLine("What is the name of the album?");
                albumName = Console.ReadLine();
                Console.WriteLine("In which year was the album produced?");
                albumReleaseYear = Console.ReadLine();
            }

            // Get the number of tracks which the user wants to add
            Console.WriteLine("Dear user, how many tracks to you intent to write: ");
            string numberOfTracksString = Console.ReadLine();
            int numberOfTracks = 0;

            while (!(int.TryParse(numberOfTracksString, out numberOfTracks) && numberOfTracks > 0))
            {
                Console.WriteLine("Dear user, please input a number larger than 0");
                numberOfTracksString = Console.ReadLine();
            }

            // Add the respective number of songs to the list of Songs
            while (numberOfTracks > 0)
            {
                Console.WriteLine("Dear user, what is the name of the song?");

                String answerFirst = Console.ReadLine();

                Console.WriteLine("Dear user, what is the duration of the song?" +
                    "\nWrite it in this format '0:00'");
                String answerSecond = Console.ReadLine();

                Song newSong = null;
                if (newAlbum)
                {
                    newSong = new Song(albumProducer, albumName, albumReleaseYear,
                    "SONG " + (songs.Count + 1).ToString(), answerFirst, answerSecond);
                }
                else
                {
                    newSong = new Song(songs.ElementAt(0).GetNameOfArtist(),
                        songs.ElementAt(0).GetNameOfAlbum(),
                        songs.ElementAt(0).GetYearOfRelease(),
                        "SONG " + (songs.Count + 1).ToString(), answerFirst, answerSecond);
                }

                // Add the new song to the list
                songs.Add(newSong);
                numberOfTracks--;
            }

            GoToFileWriting(userChoiceAlbum, songs, advertisements, newAlbum);

        }

        /// <summary>
        /// The following method writes to the repsective file
        /// </summary>
        /// <param name="userChoiceAlbum"> is the file in which we will write </param>
        /// <param name="songs"> are the songs that have to be written </param>
        /// <param name="advertisements"> are the advertisements that have to be written </param>
        /// <param name="newAlbum"> is whether a new file has to be created </param>
        public static void GoToFileWriting(string userChoiceAlbum, List<Song> songs, List<Ads> advertisements, bool newAlbum)
        { 
            
            // Write the list of Songs and the list of adds to the correct file 
            using StreamWriter file = new StreamWriter
            (Directory.GetCurrentDirectory().Replace("\\bin\\Debug\\net5.0", "\\TextFiles\\") + userChoiceAlbum + ".txt", false);
            { 
                file.WriteLine("CDS");

                if (songs.Count != 0)
                {
                    file.WriteLine(songs.ElementAt(0).ToStringSuper());
                    foreach (Song song in songs)
                    {
                        file.WriteLine(song.ToString());
                    }
                }

                file.WriteLine("ADDS");
                if (newAlbum == false)
                {
                    foreach (Ads ad in advertisements)
                    {
                        file.WriteLine(ad.ToString());
                    }
                } else
                {
                    Random rand = new Random();
                    for (int i = 0; i < songs.Count; i++)
                    {
                        file.WriteLine(advertisements.ElementAt(rand.Next(1, 26)).ToString());
                    }
                }

                 file.Close();
            }         
        }
        
        /// <summary>
        /// The following method show the next song
        /// in line. Then it changes it location to 
        /// be at the end of the album
        /// </summary>
        /// <param name="songs"> is the list of songs </param>
        /// <param name="advertisements"> is the list of ads </param>
        public static void ShowNextSong(List<Song>songs, List<Ads>advertisements)
        {
            Song song = songs.ElementAt(0);
            songs.RemoveAt(0);
            Console.WriteLine(song.Representate(0));
            songs.Add(song);

            Ads ads = advertisements.ElementAt(0);
            advertisements.RemoveAt(0);
            Console.WriteLine(ads.Representate());
            advertisements.Add(ads);
        }

        /// <summary>
        /// The following method makes a call to a method
        /// which starts a thread
        /// </summary>
        /// <param name="songs"> is the list of songs which has to be shuffled </param>
        public static void ShuffleSongs(List<Song> songs)
        {
            Console.WriteLine("Dear user, we will be implementing the" +
                "\nthe following method with the use of 'threads'");

            Thread secondThread = new Thread(() => ShuffleThread(songs));
            secondThread.Start();
        }

        /// <summary>
        /// The following method shuffels the songs using
        /// a thread implementation
        /// </summary>
        /// <param name="songs"> is the list of songs to be shuffled </param>
        public static void ShuffleThread(List<Song> songs)
        {
            Song[] songArray = new Song[songs.Count];

            List<int> chosenNumbers = new List<int>();

            Random random = new Random();
            int pickedPosition = random.Next(0, songs.Count);
            int currentLocation = 0;

            while (chosenNumbers.Count != songs.Count)
            {
                if (!chosenNumbers.Contains(pickedPosition))
                {
                    songArray[pickedPosition] = songs.ElementAt(currentLocation);
                    currentLocation++;
                    chosenNumbers.Add(pickedPosition);
                    
                }
                pickedPosition = random.Next(0, songs.Count);
            }

            songs.RemoveRange(0, songs.Count());

            for (int i = 0; i < songArray.Length; i++)
            {
                songs.Add(songArray[i]);
                songs.ElementAt(i).SetTrackNumber("SONG " + (i + 1));
            }
        }

        public static void RemoveTrack(string userChoiceAlbum, List<Song> songs, List<Ads> advertisements)
        {
            bool removeAnotherTrack = true;

            while (removeAnotherTrack)
            {
                if (songs.Count == 0)
                {
                    Console.WriteLine("Dear user, your list of songs is empty.");
                    return;
                }

                Console.WriteLine("Dear user, these are the songs inside your album of choice: " + userChoiceAlbum);

                for (int i = 0; i < songs.Count; i++)
                {
                    Console.WriteLine(songs.ElementAt(i).Representate(i + 1));
                }

                Console.WriteLine("Dear user, which track do you want to be removed?");

                int songChoice = 0;
                String toRemove = Console.ReadLine();

                while (!(int.TryParse(toRemove, out songChoice) && songChoice >= 1 && songChoice <= songs.Count))
                {
                    Console.WriteLine("Dear user, you are expected to write a number between 1 and " + songs.Count);
                    toRemove = Console.ReadLine();
                }

                songs.RemoveAt(songChoice - 1);

                Console.WriteLine("Dear user, do you want to remove another song?");
                string decision = ControlClass.StringDecision();

                if (decision.Equals("No"))
                {
                    removeAnotherTrack = false;
                }
            }
        }
    }
}
