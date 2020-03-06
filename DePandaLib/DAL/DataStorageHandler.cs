using DePandaLib.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

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
            storage = JsonSerializer.Deserialize<DataStorage>(fileContent);
        }

        public void SaveChanges()
        {
            string res = JsonSerializer.Serialize(storage);
            File.WriteAllText(StorageFileLocation, res);
        }
    }
}