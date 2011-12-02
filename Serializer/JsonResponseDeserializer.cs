using System.IO;
using Newtonsoft.Json;
using Nexmo_CSharp_lib.Interface;
using Nexmo_CSharp_lib.Model.Response;

namespace Nexmo_CSharp_lib.Serializer
{
    public class JsonResponseDeserializer : IResponseDeserializer<JsonResponseModel>
    {
        public JsonResponseModel Deserialize(Stream stream)
        {
            var sr = new StreamReader(stream);
            var output = sr.ReadToEnd();
            sr.Close();
            return Deserialize(output);
        }

        public JsonResponseModel Deserialize(string source)
        {
            var nexmoResponseModel = JsonConvert.DeserializeObject<JsonResponseModel>(source);
            return nexmoResponseModel;
        }
    }
}