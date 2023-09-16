﻿using Newtonsoft.Json;

namespace StoryTeller
{
    public static class DataLoader
    {
        public static T Load<T>(string filename) where T : class
        {
            try
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "json", filename);

                var jsonContent = File.ReadAllText(path);

                var  = JsonConvert.DeserializeObject<T>(jsonContent);

                return x;
            }
            catch (Exception ex)
            {
                // handle the exception or log it
                return null;
            }
        }
    }
}
