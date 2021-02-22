using GoltaraSolutions.Common.Domain;

namespace GoltaraSolutions.Common.Domain.Repository
{
    public interface IRepository<T> where T : Aggregate
    {
        T Find(long id);
        void Save(T model);
        void Delete(long id);
    }
}
