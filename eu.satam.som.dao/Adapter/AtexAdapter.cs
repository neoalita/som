using System.Collections.Generic;
using eu.satam.som.dao.Connector;
using eu.satam.som.dao.Model;

namespace eu.satam.som.dao.Adapter
{
    public class AtexAdapter : AdapterBase<Atex>
    {
        public AtexAdapter(IConnector connector) 
            : base(connector)
        {
        }

        public Atex Read(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Atex> ReadAll()
        {
            throw new System.NotImplementedException();
        }

    }
}