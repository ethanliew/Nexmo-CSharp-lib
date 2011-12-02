using Nexmo_CSharp_lib.Interface;

namespace Nexmo_CSharp_lib.Model.Request
{
    public class RequestModel<T> : IRequestModel
    {
        //Required
        public string Username;
        //Required
        public string Password;

        //Required
        public string From;
        //Required
        public string To;

        public string Type;

        public T MessageRequestModel;
    }
}