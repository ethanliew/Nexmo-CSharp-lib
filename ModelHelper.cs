using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Common.Logging;

namespace Nexmo_CSharp_lib
{
    public static class ModelHelper
    {
        public static ILog Log = LogManager.GetLogger(typeof (ModelHelper));

        public static void ReadObject<T>(this T obj, int idx = 0)
        {
            Type type = obj.GetType();

            if (IsACollection(type))
            {
                var ts = obj as IEnumerable;
                foreach (var t in ts)
                    ReadObject(t, idx);
            }
            else
            {
                var fields = type.GetFields();
                foreach (var field in fields)
                {
                    //generate tab
                    var tabs = ""; for (int i = 0; i < idx; i++) tabs += "\t";

                    var fieldValue = field.GetValue(obj);

                    if (fieldValue == null)
                    {
                        Log.DebugFormat("{0}{1}: {2}", tabs, field.Name, null);
                        continue;
                    }
                    Type fieldType = fieldValue.GetType();

                    if(IsNaturalType(fieldType))
                    {
                        Log.DebugFormat("{0}{1}: {2}", tabs, field.Name, field.GetValue(obj));
                    }else
                    {
                        ReadObject(field.GetValue(obj), ++idx);
                    }
                }
            }
        }
   
        public static bool IsACollection(Type type)
        {
            bool isaCollection = type.GetInterfaces().Any(x => x.IsArray || x.IsGenericType && x.GetGenericTypeDefinition() == typeof(ICollection<>));
            return isaCollection;
        }
        public static bool IsNaturalType(Type type)
        {
            return type == typeof (char) || type == typeof (string) || type == typeof (short) || type == typeof (int) ||
                   type == typeof (float) || type == typeof (double) || type == typeof (DateTime) ||
                   type == typeof (TimeSpan);
        }
    }
}