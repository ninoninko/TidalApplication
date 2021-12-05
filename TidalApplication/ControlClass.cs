using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TidalApplication
{
    internal class ControlClass
    {
        /// <summary>
        /// The following method gets the choice
        /// which the user has made 
        /// </summary>
        /// <returns> the user's choice</returns>
        public static int GetNumberForChoice()
        {
            string choiceAsString = Console.ReadLine();
            int choiceAsInteger = 0;

            while (!(int.TryParse(choiceAsString, out choiceAsInteger) && choiceAsInteger >= 1 && choiceAsInteger <= 5))
            {
                Console.WriteLine("Dear user, you have not inputted a number" +
                    "\nbetween 1 and 5 inclusive. Please, try again");

                choiceAsString = Console.ReadLine();
            }

            return choiceAsInteger;
        }

        /// <summary>
        /// In the following method the user is asked 
        /// to pick from one of the possible options.
        /// </summary>
        /// <param name="listAlbumNames"> is the list from which the method extracts the album names </param>
        /// <returns> the user's choice for an album </returns>
        public static string getAlbumName(List<string> listAlbumNames)
        {
            Console.WriteLine("Dear user, you are asked to choose an album which" +
                "\nyou want to be opened by the program. These" +
                "\nare your available choices: ");

            foreach (string albumName in listAlbumNames)
            {
                Console.WriteLine(albumName.Replace(".txt", ""));
            }

            string userChoice = Console.ReadLine();

            while (!listAlbumNames.Contains(userChoice + ".txt"))
            {
                Console.Write("Dear user, you have not inputted a correct" +
                    "\nalbum name. Please, try again: ");
                userChoice = Console.ReadLine();
            }

            return userChoice;

        }

        /// <summary>
        /// The following methods makes a list of all possible
        /// album names.
        /// </summary>
        /// <returns> returns the created list </returns>
        public static List<string> getListCDs()
        {
            List<string> fileNames = new List<string>();

            DirectoryInfo directory = new DirectoryInfo(@"D:\C#\TidalProject\TidalApplication\TidalApplication"); //Assuming Test is your Folder

            FileInfo[] Files = directory.GetFiles("*.txt"); //Getting Text files

            foreach (FileInfo file in Files)
            {
                fileNames.Add(file.Name);
            }

            return fileNames;
        }

        /// <summary>
        /// The following methods reads through the information from a file
        /// </summary>
        /// <param name="fromAlbum"> is the file in which it looks for information </param>
        /// <param name="caseDecision"> is the information it is looking for </param>
        /// <returns></returns>
        public static List<string> getInfoAsList(string fromAlbum, int caseDecision)
        {
            List<string> list = new List<string>();
            try
            {
                string[] lines = File.ReadAllLines(@"D:\C#\TidalProject\TidalApplication\TidalApplication\" + fromAlbum + ".txt");

                foreach (string line in lines)
                {
                    if (((line.Contains("CD") || line.Contains("SONG")) && (caseDecision == 1)) 
                        || (line.Contains("ADD")) && (caseDecision == 2))
                    {
                        list.Add(line);
                    }

                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine("Dear user, something has went horribly wrong." +
                    "\nYou will be referred back to the beginning of the method.");
                getInfoAsList(fromAlbum, caseDecision);
            }

            return list;
        }

        /// <summary>
        /// The following method reads in the information from the list into
        /// classes using the inheritance structure
        /// </summary>
        /// <param name="list"> is the list from which the methods reads </param>
        /// <param name="caseDecision"> is the case scenario which the method will consider </param>
        /// <returns></returns>
        public static dynamic getClassesFromListTracks(List<string> list, int caseDecision)
        {
            List<Song> songs = new List<Song>();
            List<Ads> ads = new List<Ads>();

            if (caseDecision == 1)
            {
                string[] elements = list.ElementAt(1).Split(", ");
                for (int i = 2; i < list.Count; i++)
                {
                    string[] moreElements = list.ElementAt(i).Split(", ");
                    songs.Add(new Song(elements[0], elements[1], elements[2], moreElements[0], moreElements[1], moreElements[2]));
                }

                return songs;
            }
            
            if (caseDecision == 2)
            {
                for (int i = 1; i < list.Count; i++)
                {
                    string[] moreElements = list.ElementAt(i).Split(", ");
                    ads.Add(new Ads(moreElements[0], moreElements[1]));
                }

                return ads;
            }

            return null;

            
        }
    }
}
