using System.Collections.Generic;
using Newtonsoft.Json;
using Nexmo_CSharp_lib.Interface;

namespace Nexmo_CSharp_lib.Model.Response
{
    [JsonObject(MemberSerialization.OptOut)]
    public class JsonResponseModel : IResponseModel
    {
        [JsonProperty(PropertyName = "message-count")]
        public string MessageCount;

        [JsonProperty(PropertyName = "messages")]
        public ICollection<MessageResponseModel> MessageModels;
    }
}