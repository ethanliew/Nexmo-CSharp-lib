namespace Nexmo_CSharp_lib.Interface
{
    public interface IMessageSerializer<in T> where T : IMessageRequestModel
    {
        string Serizalize(T o);
    }
}