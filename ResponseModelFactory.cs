using System;
using System.IO;
using System.Linq;
using Nexmo_CSharp_lib.Interface;

namespace Nexmo_CSharp_lib
{
    public class ResponseModelFactory
    {
        public IResponseModel Create(string typeName, Stream stream)
        {   
            string name = typeName.FirstOrDefault().ToString().ToUpper() + string.Join("", typeName.Skip(1));
            var t = Type.GetType("Nexmo_CSharp_lib.Serializer." + name + "ResponseDeserializer");
            var responseSerializer = Activator.CreateInstance(t);

            var method = t.GetMethod("Deserialize", new[] { typeof(Stream) });
            var o = method.Invoke(responseSerializer, new object[] { stream });
            return (IResponseModel)o;
        }
    }
}