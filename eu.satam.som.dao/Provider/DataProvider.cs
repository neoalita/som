using System;
using System.Collections;
using System.Collections.Generic;
using eu.satam.som.dao.Adapter;

namespace eu.satam.som.dao.Provider
{
    public class DefaultDataProvider
    {
        private IList<IAdapter>

        public IList<T> GetAll<T>()
        {
            
        }
        public T Get<T>(int id) { throw new NotImplementedException(); }
        public bool Remove<T>() { throw new NotImplementedException(); }
        public bool Update<T>() { throw new NotImplementedException(); }
        public bool Add<T>() { throw new NotImplementedException(); }
    }
}