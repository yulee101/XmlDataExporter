using System.Collections.Generic;

namespace XmlDataExporter
{
    public class File : IFile
    {
        private string fileName;
        private string filePath;
        private List<TrackingObjectModel> exportData;

        public string FileName { get => fileName; set => fileName = value; }
        public string FilePath { get => filePath; set => filePath = value; }
        public List<TrackingObjectModel> SelectedXmlData { get => exportData; set => exportData = value; }
    }
}
