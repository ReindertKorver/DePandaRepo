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

        public static void Init(byte[] storageFile)
        {
            string fileContent = System.Text.Encoding.UTF8.GetString(storageFile);
            Storage = JsonConvert.DeserializeObject<DataStorage>(fileContent);
        }

        public static void SaveChanges()
        {
            string res = JsonConvert.SerializeObject(Storage);
            File.WriteAllText(StorageFileLocation, res);
        }
    }
}