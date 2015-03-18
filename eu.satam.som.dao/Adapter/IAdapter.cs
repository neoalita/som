using System.Collections.Generic;
using eu.satam.som.dao.Connector;

namespace eu.satam.som.dao.Adapter
{
    public interface IAdapter<T>
    {
        T Read(int id);
        IList<T> ReadAll();
    }

    public abstract class AdapterBase : IAdapter
    {
        protected IConnector Connector { get; set; }

        protected AdapterBase(IConnector connector)
        {
            Connector = connector;
        }

        public abstract T1 Read<T1>(int id);

        public abstract IList<T1> ReadAll<T1>();
    }
}