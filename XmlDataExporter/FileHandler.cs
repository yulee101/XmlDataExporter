using System;
using System.Xml;

namespace XmlDataExporter
{
    public static class FileHandler
    {
        const string XmlFileEnding = ".xml";
        public static bool CheckIfFileIsXmlfile(IFile file)
        {
            if (file is null)
            {
                throw new ArgumentNullException(nameof(file));
            }

            if (file.FileName.Contains(XmlFileEnding))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckIfFileContainsValidData(IFile file)
        {
            XmlDocument reader = new XmlDocument();
            reader.Load(file.FilePath);

            if ((reader.GetElementsByTagName("d2p1:TrackingObject").Count > 0) && 
                (reader.GetElementsByTagName("d2p1:BrowserEnvironment").Count > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
