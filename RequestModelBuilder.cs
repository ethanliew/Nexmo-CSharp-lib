using Nexmo_CSharp_lib.Interface;
using Nexmo_CSharp_lib.Model.Request;

namespace Nexmo_CSharp_lib
{
    public class RequestModelBuilder
    {
        public RequestModel<T> Create<T>(string username, string password, string from, string to, T messageRequestModel)
            where T : IMessageRequestModel
        {
            var type = messageRequestModel.GetTypeName();
            return new RequestModel<T>
                       {
                           Username = username,
                           Password = password,
                           From = from,
                           To = to,
                           Type = type,
                           MessageRequestModel = messageRequestModel
                       };
        }

        public RequestModel<T> Create<T>(RequestModel<T> requestModel, T messageRequestModel)
            where T : IMessageRequestModel
        {
            var type = messageRequestModel.GetTypeName();
            requestModel.Type = type;
            requestModel.MessageRequestModel = messageRequestModel;
            return requestModel;
        }
    }
}