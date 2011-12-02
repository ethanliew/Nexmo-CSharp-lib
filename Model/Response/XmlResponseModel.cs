using System.Xml.Serialization;
using Nexmo_CSharp_lib.Interface;

namespace Nexmo_CSharp_lib.Model.Response
{
    [XmlRoot("mt-submission-response")]
    public class XmlResponseModel : IResponseModel
    {
        [XmlElement("messages")]
        public XmlMessagesModel Messages;
    }
}