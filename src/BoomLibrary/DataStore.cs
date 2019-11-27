using System;
using System.IO;
using Newtonsoft.Json;

namespace BoomLibrary
{
    class DataStore
    {
        public string DbConnectionString { get; }
        public string FileStorePath { get; }
        private string jsonOutput;
        private string dataJsonPath;
        private JsonSerializer serializer = new JsonSerializer();
        
        /// <summary>
        /// Using a Database to store data
        /// </summary>
        /// <param name="ConnectionString"></param>
        public DataStore(string ConnectionString)
        {
            DbConnectionString = ConnectionString;
        }

        /// <summary>
        /// Storage on local machine as Json
        /// </summary>
        /// <param name="path"></param>
        public DataStore()
        {

        }

        private void SerializeToJson(User user)
        {
            try
            {
                jsonOutput = JsonConvert.SerializeObject(
                    user, Formatting.Indented);
            }
            catch (System.Exception)
            {
                throw new System.Exception(
                    "Data could not be converted to JSON");
            }
        }
        
        public void SaveToHdd(User user)
        {
            SerializeToJson(user);
            DirectoryInfo dataDirectory = new DirectoryInfo("./data");
            dataJsonPath = Path.Combine(dataDirectory.FullName, "user.json");

            if (dataDirectory.Exists)
            {
                WriteTextToFile(dataDirectory.FullName, jsonOutput);
            }
        }

        public User LoadFromHdd()
        {
            User user = JsonConvert.DeserializeObject<User>(File.ReadAllText(dataJsonPath));
            return user;
        }

        public void SaveToDb()
        {
            throw new NotImplementedException();
        }

        private void WriteTextToFile(string path, string data)
        {
            File.WriteAllText(path, data);
        }
    }
}