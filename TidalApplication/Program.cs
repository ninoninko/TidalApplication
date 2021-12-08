using System;
using System.Collections.Generic;
using System.IO;

namespace TidalApplication
{
    internal class Program
    {
        /// <summary>
        /// Main methods of the application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            DoesUserOnlyWantToAddSongs();
            InfoCreaterMethod();           

        }

        /// <summary>
        /// The following method creates all of the information that is needed for the execution of the program
        /// </summary>
        public static void InfoCreaterMethod()
        {
            // This list is the list of the names of the available albums
            List<string> listAlbumNames = ControlClass.getListCDs();

            // This string is the album which the user has chosen to open
            string userChoiceAlbum = ControlClass.getAlbumName(listAlbumNames);

            // This is a string representation of the tracks inside the albums + the album name 
            List<string> tracks = ControlClass.getInfoAsList(userChoiceAlbum, 1);

            // This is a Song object representation of the tracks from the 'tracks' list
            List<Song> songs = ControlClass.getClassesFromListTracks(tracks, 1);

            // This is a string representation of the ads inside the albums  
            List<string> ads = ControlClass.getInfoAsList(userChoiceAlbum, 2);
            
            // This is a Ads object representation of the ads from the 'ads' list
            List<Ads> advertisements = ControlClass.getClassesFromListTracks(ads, 2);
            
            SwitchChoice(userChoiceAlbum, songs, advertisements);
        }
        /// <summary>
        /// The following method visualizes the user's
        /// possible option for interaction.
        /// </summary>
        public static int MenuMethod()
        {
            Console.WriteLine("Dear user, please pick an option from our menu:" +
                "\n1 - Show the current playlist" +
                "\n2 – Add a new CD including songs" +
                "\n3 – Play" +
                "\n4 – Shuffle" +
                "\n5 – Stop the program");

            // Get the user's choice to proceed
            int userChoice = ControlClass.GetNumberForChoice();

            return userChoice;
        }

        /// <summary>
        /// The following method holds the control
        /// over the program by calling different
        /// methods in different classes
        /// </summary>
        /// <param name="userChoice"></param>
        public static void SwitchChoice(string userChoiceAlbum, List<Song> songs, List<Ads> advertisements)
        {

            int userChoice = MenuMethod();
            switch(userChoice)
            {
                case 1:
                    ProgramCases.RepresentLists(songs, advertisements);
                    SwitchChoice(userChoiceAlbum, songs, advertisements);
                    break;
                case 2:
                    ProgramCases.WriteToFiles(songs, advertisements);
                    SwitchChoice(userChoiceAlbum, songs, advertisements);
                    break;
                case 3:
                case 4:
                    Console.WriteLine("Dear user, we are still working on option " + userChoice +
                        ".\nPlease, excuse us for any inconvenience. You will be" +
                        "\nrefered back to the main menu.");
                    SwitchChoice(userChoiceAlbum, songs, advertisements);
                    break;
                case 5:
                    Console.WriteLine("Dear user, you have decided to cancel" +
                        "\nthe execution of the following program." +
                        "\nThank you for using our services.");
                    Environment.Exit(0);
                    break;
                
            }
        }

        /// <summary>
        /// The following method circumvents the swtich in
        /// the main part of the application to offer a
        /// faster user experience
        /// </summary>
        public static void DoesUserOnlyWantToAddSongs()
        {
            Console.WriteLine("Dear user, do you want to add a song to a NEW album" +
                "\ninstead of starting the entire application?" +
                "\nPlease, type 'yes' if that is what you want.");

            string decision = Console.ReadLine();

            if (decision.Equals("yes"))
            {
                Console.WriteLine("How do you want to name your new album?");
                string chosenAlbums = Console.ReadLine();
                ProgramCases.DontCreateAlbum(chosenAlbums, null, null, true);
            }

            Console.WriteLine("Dear user, do you want to terminate the" +
                "\nexecution of the aplication?" +
                "\nPlease, type 'yes' if that is what you want.");

            decision = Console.ReadLine();

            if (decision.Equals("yes"))
            {
                Environment.Exit(1);
            }
        }
    }
}
