using System.Xml;

namespace XmlDataReader
{
    public class File
    {
        private string fileName;
        private string filePath;

        public string FileName { get => fileName; set => fileName = value; }
        public string FilePath { get => filePath; set => filePath = value; }

        public File(string fileName, string filePath)
        {
            FileName = fileName;
            FilePath = filePath;
        }
    }
}
