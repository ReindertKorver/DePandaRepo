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
        public string StorageFileLocation { get; set; }
        public DataStorage storage { get; set; }

        public DataStorageHandler(byte[] storageFile)
        {
            string fileContent = System.Text.Encoding.UTF8.GetString(storageFile);
            storage = JsonConvert.DeserializeObject<DataStorage>(fileContent);
        }

        public void SaveChanges()
        {
            string res = JsonConvert.SerializeObject(storage);
            File.WriteAllText(StorageFileLocation, res);
        }
    }
}