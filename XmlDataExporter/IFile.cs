using System.Collections.Generic;

namespace XmlDataExporter
{
    public interface IFile
    {
        List<TrackingObjectModel> SelectedXmlData { get; set; }
        string FileName { get; set; }
        string FilePath { get; set; }
    }
}