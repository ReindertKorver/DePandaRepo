using DePandaLib.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DePandaLib.DAL
{
    /// <summary>
    /// Handles the data storage for DePanda
    /// </summary>
    public class DataStorageHandler
    {
        public static string StorageFileLocation { get; set; }
        public static DataStorage Storage { get; set; }

        public static void Init()
        {
            string fileContent = File.ReadAllText(StorageFileLocation);
            try
            {
                Storage = JsonConvert.DeserializeObject<DataStorage>(fileContent);
            }
            catch (Exception)
            {
                Storage = new DataStorage();
            }
        }

        public static void SaveChanges()
        {
            string res = JsonConvert.SerializeObject(Storage, Formatting.Indented,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });
            File.WriteAllText(StorageFileLocation, res);
        }
    }
}