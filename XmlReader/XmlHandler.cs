using System.IO;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System;
using System.Xml;
using System.Xml.Schema;
using System.Reflection;

namespace XmlDataReader
{
    public static class XmlHandler
    {
        //public delegate void XmlElementEventHandler(object? sender, XmlElementEventArgs e);

        public static T DeserializeXml<T>(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new System.ArgumentException($"'{nameof(filePath)}' cannot be null or empty", nameof(filePath));
            }

            XmlSerializer serializer = new XmlSerializer(typeof(T));
            //serializer.UnknownElement += XmlElementEventHandler(Serializer_UnknownElement);
            string xmlPath = Path.GetFullPath(filePath);
            using (FileStream fileStream = new FileStream(xmlPath, FileMode.Open))
            {
                return (T)serializer.Deserialize(fileStream);


            }
        }

        private static void Serializer_UnknownElement(object sender, XmlElementEventArgs e)
        {
            Group x = (Group)e.ObjectBeingDeserialized;
        }
    }
    public class Group
    {
        public string GroupName;
    }
}