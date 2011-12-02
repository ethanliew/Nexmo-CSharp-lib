using System.Xml.Serialization;

namespace Nexmo_CSharp_lib.Model.Response
{
    public class XmlMessagesModel
    {
        [XmlAttribute("count")]
        public string MessageCount;

        [XmlElement("message")]
        public MessageResponseModel[] MessageModels;
    }
}