using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlDataReader
{
    public static class FileHandler
    {
        const string XmlFileEnding = ".xml";
        public static bool CheckIfFileIsXmlfile(File file)
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

        public static bool CheckIfFileDataIsValid(File file)
        {
            XmlDocument reader = new XmlDocument();
            reader.Load(file.FilePath);

            var test1 = reader.GetElementsByTagName("d2p1:TrackingObject");
            var test2 = reader.GetElementsByTagName("d2p1:BrowserEnvironment");

            if (test1.Count > 0 && test2.Count > 0)
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
