using System;
using System.Collections.Generic;
using System.Text;

namespace XmlDataReader
{
    class ExportData
    {
        private List <Dictionary<string, string>> data;
        public List<Dictionary<string, string>> Data { get => data; set => data = value; }


        public ExportData()
        {
            
        }
        public ExportData(List<Dictionary<string, string>> data)
        {
            Data = data;
        }
    }
}
