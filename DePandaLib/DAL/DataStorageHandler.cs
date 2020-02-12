using DePandaLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DePandaLib.DAL
{
    /// <summary>
    /// Handles the data storage for DePanda
    /// </summary>
    public class DataStorageHandler : ICRUD
    {
        /// <summary>
        /// Creates a new object in storage
        /// Use case:
        /// </summary>
        /// <example>
        ///  DataStorageHandler dth = new DataStorageHandler();
        ///  dth.Create<Dish>(dish);
        /// </example>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public T Create<T>(T obj) where T : class, new()
        {
            Console.WriteLine("DataStorageHandler.Create is'nt implemented yet");
            return obj;
        }

        /// <summary>
        /// Deletes an object in storage by its key
        /// Use case:
        /// </summary>
        /// <example>
        ///  DataStorageHandler dth = new DataStorageHandler();
        ///  dth.Delete<Dish>("key");
        /// </example>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public void Delete<T>(string key)
        {
            Console.WriteLine("DataStorageHandler.Delete is'nt implemented yet");
        }

        /// <summary>
        /// Returns an object from storage
        /// Use case:
        /// </summary>
        /// <example>
        ///  DataStorageHandler dth = new DataStorageHandler();
        ///  dth.Read<Dish>("key");
        /// </example>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public T Read<T>(string key) where T : class, new()
        {
            Console.WriteLine("DataStorageHandler.Read is'nt implemented yet");
            return new T() { };
        }

        /// <summary>
        /// Updates an object in storage
        /// Use case:
        /// </summary>
        /// <example>
        ///  DataStorageHandler dth = new DataStorageHandler();
        ///  dth.Update<Dish>(dish);
        /// </example>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public T Update<T>(T obj) where T : class, new()
        {
            Console.WriteLine("DataStorageHandler.Update is'nt implemented yet");
            return obj;
        }
    }
}