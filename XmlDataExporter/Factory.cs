using System.Collections.Generic;

namespace XmlDataExporter
{
    public static class Factory
    {
        public static IFile CreateFile()
        {
            return new File();
        }
        public static List <TrackingObjectModel> CreateExportDataContainer()
        {
            return new List <TrackingObjectModel>();
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }
    }
}