using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace XmlDataExporter
{
    public class DataContentModel
    {
        [XmlElement(ElementName = "TrackingObject", Namespace = "http://schemas.datacontract.org/2004/07/Grollmus.TstCloud.Business")]
        public List<TrackingObjectModel> TrackingList { get; set; }
    }
}
