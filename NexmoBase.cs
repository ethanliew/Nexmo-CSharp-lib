using System;
using System.IO;
using System.Net;
using Common.Logging;

namespace Nexmo_CSharp_lib
{
    public abstract class NexmoBase
    {
        protected ILog Log = LogManager.GetLogger(typeof(NexmoBase));

        protected Stream SendRequest(string url, string responseType, string requestparamters, string method)
        {
            try
            {
                var path = string.Concat(url, responseType, requestparamters);
                var webRequest = WebRequest.Create(path) as HttpWebRequest;
                webRequest.Credentials = CredentialCache.DefaultCredentials;
                webRequest.Method = method;
                webRequest.ContentType = "application/x-www-form-urlencoded";
                webRequest.Accept = string.Concat("application/", responseType);

                var response = webRequest.GetResponse();
                var stream = response.GetResponseStream();
                return stream;
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
            }
            return null;
        }
    }
}