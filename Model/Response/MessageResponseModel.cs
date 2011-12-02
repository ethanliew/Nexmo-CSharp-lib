using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Nexmo_CSharp_lib.Model.Response
{
    public class MessageResponseModel
    {
        [XmlElement("status")]
        [JsonProperty(PropertyName = "status")]
        public string Status;

        [XmlElement("messageId")]
        [JsonProperty(PropertyName = "message-id")]
        public string MessageId;

        [XmlElement("clientRef")]
        [JsonProperty(PropertyName = "client-ref")]
        public string ClientRef;

        [XmlElement("remainingBalance")]
        [JsonProperty(PropertyName = "remaining-balance")]
        public string RemainingBalance;

        [XmlElement("messagePrice")]
        [JsonProperty(PropertyName = "message-price")]
        public string MessagePrice;

        [XmlElement("errorText")]
        [JsonProperty(PropertyName = "error-text")]
        public string ErrorText;
    }
}