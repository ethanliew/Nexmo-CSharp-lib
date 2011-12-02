using System.IO;

namespace Nexmo_CSharp_lib.Interface
{
    public interface IResponseDeserializer<out T> where T : IResponseModel
    {
        T Deserialize(Stream stream);
    }
}