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

            List<string> listAlbumNames = ControlClass.getListCDs();

            string userChoiceAlbum = ControlClass.getAlbumName(listAlbumNames);

            List<string> tracks = ControlClass.getInfoAsList(userChoiceAlbum, 1);

            List<string> ads = ControlClass.getInfoAsList(userChoiceAlbum, 2);

            MenuMethod();

        }

        /// <summary>
        /// The following method visualizes the user's
        /// possible option for interaction.
        /// </summary>
        public static void MenuMethod()
        {
            Console.WriteLine("Dear user, please pick an option from our menu:" +
                "\n1 - Show the current playlist" +
                "\n2 – Add a new CD including songs" +
                "\n3 – Play" +
                "\n4 – Shuffle" +
                "\n5 – Stop the program");

            int userChoice = ControlClass.GetNumberForChoice();

            SwitchChoice(userChoice);
        }

        /// <summary>
        /// The following method holds the control
        /// over the program by calling different
        /// methods in different classes
        /// </summary>
        /// <param name="userChoice"></param>
        public static void SwitchChoice(int userChoice)
        {
            switch(userChoice)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Dear user, we are still working on option " + userChoice +
                        ".\nPlease, excuse us for any inconvenience. You will be" +
                        "\nrefered back to the main menu.");
                    MenuMethod();
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
