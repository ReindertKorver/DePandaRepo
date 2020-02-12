using System;
using System.Collections.Generic;
using System.Text;

namespace DePandaLib.Interfaces
{
    public interface ICRUD
    {
        T Create<T>(T obj) where T : class, new();

        T Read<T>(string key) where T : class, new();

        T Update<T>(T obj) where T : class, new();

        void Delete<T>(string key);
    }
}