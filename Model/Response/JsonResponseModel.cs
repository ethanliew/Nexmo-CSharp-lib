using System.Collections.Generic;
using Nexmo_CSharp_lib.Interface;

namespace Nexmo_CSharp_lib.Model.Response
{
    public class JsonResponseModel :IResponseModel
    {      
        public string MessageCount;
  
        public ICollection<MessageResponseModel> MessageModels;
    }
}