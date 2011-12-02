using System.Text;
using Nexmo_CSharp_lib.Model.Request;

namespace Nexmo_CSharp_lib.Interface
{
    public interface IRequestSerializer
    {
        StringBuilder Serialize<T, TV>(T o)
            where T : RequestModel<TV>
            where TV : IMessageRequestModel;
    }
}