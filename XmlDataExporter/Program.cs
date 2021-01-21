using System;
using System.IO;

namespace XmlDataExporter
{
    class Program
    {

        /*TODO:
         * - Unittests
         * - Darstellung der exportierten Daten auf der Konsole oder in WPF Form (Bisher werden die Daten nur in einem Objekt gespeichert
         * Ziel ist, dass die Daten vielleicht von einem DataHandler aufgegriffen werden und dann in Excel exportiert werden
         * 
         */
        static void Main(string[] args)
        {
            string folderDirectory = String.Empty;
            do {
                Console.WriteLine("Bitte geben Sie einen gültigen Pfad ein:");
                folderDirectory = Console.ReadLine();
            } while (!InputValidator.CheckInputForValidity(folderDirectory));

                ILogger logger = Factory.CreateLogger();
                var allFiles = Directory.GetFiles(folderDirectory);

                foreach (var filePath in allFiles)
                {
                    IFile temp = Factory.CreateFile();
                    temp.FileName = Path.GetFileName(filePath);
                    temp.FilePath = filePath;
                    if (FileHandler.CheckIfFileIsXmlfile(temp) && FileHandler.CheckIfFileContainsValidData(temp))
                    {
                        temp.SelectedXmlData = Factory.CreateExportDataContainer();
                        temp.SelectedXmlData = XmlHandler.DeserializeXml<WebResponseModel>($"{filePath}").DataContent.TrackingList;
                    logger.Log($"Daten von Datei {temp.FileName} erfolgreich eingelesen.");
                }
                }
                logger.Log("Datenauswertung beendet.");
                Console.ReadKey();
            }
    }
}