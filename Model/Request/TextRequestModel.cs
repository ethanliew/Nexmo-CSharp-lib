using Nexmo_CSharp_lib.Interface;

namespace Nexmo_CSharp_lib.Model.Request
{
    public class TextRequestModel : IMessageRequestModel
    {
        //Required when type='text'.

        public string Text;

        public string StatusReportReq;

        public string ClientRef;

        public string NetworkCode;

        public string VCard;

        public string VCal;

        public string Ttl;

        public string GetTypeName()
        {
            return "text";
        }
    }
}