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

        public DataStorageHandler(string storageFileLocation)
        {
            this.StorageFileLocation = storageFileLocation;
            string fileContent = File.ReadAllText(StorageFileLocation);
            storage = JsonConvert.DeserializeObject<DataStorage>(fileContent);
        }

        public void SaveChanges()
        {
            string res = JsonConvert.SerializeObject(storage);
            File.WriteAllText(StorageFileLocation, res);
        }
    }
}