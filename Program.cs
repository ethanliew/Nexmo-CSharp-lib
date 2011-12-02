using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.Logging;
using Nexmo_CSharp_lib.Model.Request;

namespace Nexmo_CSharp_lib
{
    class Program
    {
        protected static ILog Log = LogManager.GetLogger(typeof(Program));


        static void Main(string[] args)
        {
            Log.Info("::Nexmo::");
            
            JsonExample();

            Console.ReadLine();
        }

        private static void JsonExample()
        {
            Log.Info("- JsonExample -");

            var textModel = new TextRequestModel {Text = "HelloWorld!"};

            var requestModel = RequestModelBuilder.Create("{USERNAME}", "{PASSWORD}", "{FROM}", "{TO}", textModel);
         
            var nexmo = new Nexmo();
            
            var responseModel = nexmo.Send(requestModel, ResponseObjectType.Json);

            Log.Info("- Result -");
            responseModel.ReadObject();

            Log.Info("- End -");
        }
    }
}
