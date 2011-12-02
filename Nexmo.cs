using System.IO;
using Nexmo_CSharp_lib.Interface;
using Nexmo_CSharp_lib.Model.Request;

namespace Nexmo_CSharp_lib
{
    public sealed class Nexmo : NexmoBase
    {
        private const string NxURL = "https://rest.nexmo.com/sms/";

        private readonly NexmoConventer _nexmoConventer;
        
        public Nexmo(): this(new NexmoConventer()){}

        public Nexmo(NexmoConventer nexmoConventer)
        {
            _nexmoConventer = nexmoConventer;
        }

        private Stream SendRequest<T, TV>(T nexmoRequestModel, ResponseObjectType responseObjectType)
            where TV : IMessageRequestModel
            where T : RequestModel<TV>
        {
            var requestparamters = _nexmoConventer.SerializerequestObject(nexmoRequestModel);
            string responseType = responseObjectType.ToString().ToLower();
            return SendRequest(NxURL, responseType, requestparamters, "POST");
        }

        public IResponseModel Send<T>(RequestModel<T> nexmoRequestModel,ResponseObjectType responseObjectType = ResponseObjectType.Json)
             where T : IMessageRequestModel
        {
            var responseStream = SendRequest<RequestModel<T>,T>(nexmoRequestModel, responseObjectType);
            var responseModel = _nexmoConventer.DeSerializeresponseObject(responseStream, responseObjectType);
            return responseModel;
        }
    }
}