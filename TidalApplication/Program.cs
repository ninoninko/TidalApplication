using System;
using System.Collections.Generic;
using System.IO;

namespace TidalApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> listAlbumNames = getListCDs();

            string userChoiceAlbum = getAlbumName(listAlbumNames);
             Console.WriteLine(userChoiceAlbum);
            MenuMethod();

        }

        public static string getAlbumName(List<string> listAlbumNames)
        {
            Console.WriteLine("Dear user, you are asked to choose an album which" +
                "\nyou want to be opened by the program. These" +
                "\nare your available choices: ");

            foreach(string albumName in listAlbumNames)
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
