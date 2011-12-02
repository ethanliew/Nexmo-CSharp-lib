using System.IO;
using Common.Logging;
using Nexmo_CSharp_lib.Interface;
using Nexmo_CSharp_lib.Model.Request;
using Nexmo_CSharp_lib.Serializer;

namespace Nexmo_CSharp_lib
{
    public class NexmoConventer
    {
        protected ILog Log = LogManager.GetLogger(typeof (NexmoConventer));
        protected ResponseModelFactory ResponseModelFactory;
        protected RequestSerializer RequestSerializer;

        public NexmoConventer(): this(new ResponseModelFactory(),new RequestSerializer()){}

        public NexmoConventer(ResponseModelFactory responseModelFactory,RequestSerializer requestSerializer)
        {
            ResponseModelFactory = responseModelFactory;
            RequestSerializer = requestSerializer;
        }

        public string SerializerequestObject<T>(RequestModel<T> o) where T : IMessageRequestModel
        {
            var sb = RequestSerializer.Serialize<RequestModel<T>, T>(o);
            return sb.ToString();
        }

        public  IResponseModel DeSerializeresponseObject(Stream stream, ResponseObjectType responseObjectType)
        {
            var responseModel = ResponseModelFactory.Create(responseObjectType.ToString(), stream);
            return responseModel;
        }
    }
}