using Nexmo_CSharp_lib.Interface;
using Nexmo_CSharp_lib.Model.Request;

namespace Nexmo_CSharp_lib.Serializer
{
    public class TextRequestSerializer : IMessageSerializer<TextRequestModel>
    {
        public string Serizalize(TextRequestModel o)
        {
            return
                string.Format(
                    "&text={0}&status-report-req={1}&client-ref={2}&network-code={3}&vcard={4}&vcal={5}&ttl={6}", o.Text,
                    o.StatusReportReq, o.ClientRef, o.NetworkCode, o.VCard, o.VCal, o.Ttl);
        }
    }
}