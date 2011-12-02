using System.Text;
using Common.Logging;
using Nexmo_CSharp_lib.Interface;
using Nexmo_CSharp_lib.Model.Request;

namespace Nexmo_CSharp_lib.Serializer
{
    public class RequestSerializer : IRequestSerializer
    {
        protected ILog Log = LogManager.GetLogger(typeof(RequestSerializer));

        private readonly MessageRequestSerializerFactory _messageRequestSerializerFactory;

        public RequestSerializer() : this(new MessageRequestSerializerFactory()){}

        public RequestSerializer(MessageRequestSerializerFactory messageRequestSerializerFactory)
        {
            _messageRequestSerializerFactory = messageRequestSerializerFactory;
        }

        public StringBuilder Serialize<T,TV>(T o) 
            where T : RequestModel<TV>
            where TV : IMessageRequestModel
        {
            var sb = new StringBuilder();
            sb.AppendFormat("?username={0}&password={1}&from={2}&to={3}&type={4}", o.Username, o.Password, o.From, o.To, o.Type);

            var messageSerializer = _messageRequestSerializerFactory.Create(o.MessageRequestModel);
            var subrequestString = messageSerializer.Serizalize(o.MessageRequestModel);
            sb.Append(subrequestString);
            return sb;
        }
    }

}