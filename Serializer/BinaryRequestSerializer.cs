using Nexmo_CSharp_lib.Interface;
using Nexmo_CSharp_lib.Model.Request;

namespace Nexmo_CSharp_lib.Serializer
{
    public class BinaryRequestSerializer : IMessageSerializer<BinaryRequestModel>
    {
        public string Serizalize(BinaryRequestModel o)
        {
            return string.Format("&body={0}&udh={1}", o.Body, o.Udh);
        }
    }
}