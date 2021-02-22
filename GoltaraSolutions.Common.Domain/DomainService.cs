using System.Collections.Generic;

namespace GoltaraSolutions.Common.Domain
{
    public abstract class DomainService<T>
    {

        public abstract void Delete(long id);
        public abstract void Recover(long id);
        public abstract T Find(long id);
        public abstract T Find(long idEmpresa, string nome);
        public abstract IEnumerable<T> List(long idEmpresa);
    }
}