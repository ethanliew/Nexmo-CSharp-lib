using System;
using System.Linq;
using Nexmo_CSharp_lib.Interface;

namespace Nexmo_CSharp_lib
{
    public class MessageRequestSerializerFactory      
    {
        public IMessageSerializer<TV> Create<TV>(TV messageRequestModel) 
            where TV : IMessageRequestModel
        {
            string typeName = messageRequestModel.GetTypeName();
            string name = typeName.FirstOrDefault().ToString().ToUpper() + string.Join("", typeName.Skip(1));
            var t = Type.GetType("Nexmo_CSharp_lib.Serializer." + name + "RequestSerializer");
            var messageSerializer = (IMessageSerializer<TV>)Activator.CreateInstance(t);
            return messageSerializer;
        }
    }
}