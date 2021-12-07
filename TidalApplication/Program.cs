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
           
            InfoCreaterMethod();           

        }

        /// <summary>
        /// The following method creates all of the information that is needed for the execution of the program
        /// </summary>
        public static void InfoCreaterMethod()
        {
            List<string> listAlbumNames = ControlClass.getListCDs();

            string userChoiceAlbum = ControlClass.getAlbumName(listAlbumNames);

            List<string> tracks = ControlClass.getInfoAsList(userChoiceAlbum, 1);

            List<Song> songs = ControlClass.getClassesFromListTracks(tracks, 1);
            
            List<string> ads = ControlClass.getInfoAsList(userChoiceAlbum, 2);

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
    }
}
