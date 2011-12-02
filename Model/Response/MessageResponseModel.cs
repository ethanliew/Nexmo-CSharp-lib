using Newtonsoft.Json;

namespace Nexmo_CSharp_lib.Model.Response
{
    public class MessageResponseModel
    {
       
        [JsonProperty(PropertyName = "status")]
        public string Status;

        [JsonProperty(PropertyName = "message-id")]
        public string MessageId;
   
        [JsonProperty(PropertyName = "client-ref")]
        public string ClientRef;

        [JsonProperty(PropertyName = "remaining-balance")]
        public string RemainingBalance;
     
        [JsonProperty(PropertyName = "message-price")]
        public string MessagePrice;
    
        [JsonProperty(PropertyName = "error-text")]
        public string ErrorText;
    }
}