using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace XmlDataReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderDirectory = "";
            do
            {
                Console.WriteLine("Bitte geben Sie einen gültigen Pfad ein.");
                folderDirectory = Console.ReadLine();
            } while (String.IsNullOrEmpty(folderDirectory) || String.IsNullOrWhiteSpace(folderDirectory)) ;

            //TODO: was passiert, wenn Ordner Unterordner besitzt?

            if (Directory.Exists(folderDirectory))
            {
                var allFiles = Directory.GetFiles(folderDirectory);

                foreach (var filePath in allFiles)
                {
                    //File temp = new File();

                    //if(FileHandler.CheckIfFileIsXmlfile(filePath))
                    var result = XmlHandler.DeserializeXml<WebResponseOfTrackingObjectsModel>(@$"{filePath}");
                    int unser = 0;
                }
            }
        }
    }
}