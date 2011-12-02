using Nexmo_CSharp_lib.Interface;

namespace Nexmo_CSharp_lib.Model.Response
{
    public class XmlResponseModel : IResponseModel
    {       
        public XmlMessagesModel Messages;       
    }

    public class XmlMessagesModel
    {      
        public string MessageCount;
        public MessageResponseModel[] MessageModels;
    }
}