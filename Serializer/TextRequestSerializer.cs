using System.Text;
using Nexmo_CSharp_lib.Interface;
using Nexmo_CSharp_lib.Model.Request;

namespace Nexmo_CSharp_lib.Serializer
{
    public class TextRequestSerializer : IMessageSerializer<TextRequestModel>
    {
        public string Serizalize(TextRequestModel o)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("&text={0}", o.Text);
            if (o.StatusReportReq != null)
                sb.AppendFormat("&status-report-req={0}",o.StatusReportReq);
            if(o.ClientRef !=null)
                sb.AppendFormat("&client-ref={0}", o.ClientRef);
            if(o.NetworkCode !=null)
                sb.AppendFormat("&network-code={0}", o.NetworkCode);
            if(o.VCard !=null)
                sb.AppendFormat("&vcard={0}", o.VCard);
            if(o.VCal !=null)
                sb.AppendFormat("&vcal={0}", o.VCal);
            if(o.Ttl !=null)
                sb.AppendFormat("&ttl={0}", o.Ttl);
            return sb.ToString();
        }
    }
}