using Nexmo_CSharp_lib.Interface;

namespace Nexmo_CSharp_lib.Model.Request
{
    public class BinaryRequestModel : IMessageRequestModel
    {
        public string Body;

        public string Udh;

        public string GetTypeName()
        {
            return "binary";
        }
    }
}