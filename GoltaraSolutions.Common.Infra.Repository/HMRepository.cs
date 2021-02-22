using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace GoltaraSolutions.Common.Infra.Repository
{
    public class HMRepository<T> : IDbSet<T>
    where T : class
    {
        ObservableCollection<T> _data;
        IQueryable _query;
        private string _idPropName = "Id";
        public HMRepository()
        {
            _data = new ObservableCollection<T>();
            _query = _data.AsQueryable();
        }
        public HMRepository(string idPropName) : base()
        {
            _idPropName = idPropName;
        }

        public virtual T Find(params object[] keyValues)
        {
            throw new NotImplementedException("Derive from HMRepository<T> and override Find");
        }

        public T Add(T item)
        {
            int idAtual = int.Parse(item.GetType().GetProperty(_idPropName)?.GetValue(item).ToString());

            setPropValue(item, _idPropName, idAtual);

            _data.Add(item);
            return item;
        }

        public T Remove(T item)
        {
            _data.Remove(item);
            return item;
        }

        public T Create()
        {
            return Activator.CreateInstance<T>();
        }

        public TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, T
        {
            return Activator.CreateInstance<TDerivedEntity>();
        }

        public ObservableCollection<T> Local
        {
            get { return _data; }
        }

        Type IQueryable.ElementType
        {
            get { return _query.ElementType; }
        }

        System.Linq.Expressions.Expression IQueryable.Expression
        {
            get { return _query.Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return _query.Provider; }
        }

        System.Collections.IEnumerator IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }
        private void setPropValue(object src, string propName, int id)
        {
            int nextID = _data.Count() + 1;

            if (id != 0)
            {
                nextID = id;
            }

            src.GetType().GetProperty(propName)?.SetValue(src,
                nextID);
        }
    }
}