﻿using Newtonsoft.Json;

namespace ETProjeOdevi.WebUI.ExtensionMethods
{
    public static class SessionExtensionMethods
    {
        public static void Setjson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static T? GetJson<T>(this ISession session, string key) where T : class
        {
            var data = session.GetString(key);  


            return data == null ? default(T) : JsonConvert.DeserializeObject<T>(data);
        }

       
    }
}