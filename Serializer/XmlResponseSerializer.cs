using System.IO;
using System.Xml.Serialization;
using Nexmo_CSharp_lib.Interface;
using Nexmo_CSharp_lib.Model.Response;

namespace Nexmo_CSharp_lib.Serializer
{
    public class XmlResponseSerializer : IResponseDeserializer<XmlResponseModel>
    {
        public XmlResponseModel Deserialize(Stream stream)
        {
            var xmlSerializer = new XmlSerializer(typeof (XmlResponseModel));
            var nexmoResponseModel = (XmlResponseModel) xmlSerializer.Deserialize(stream);
            return nexmoResponseModel;
        }
    }
}