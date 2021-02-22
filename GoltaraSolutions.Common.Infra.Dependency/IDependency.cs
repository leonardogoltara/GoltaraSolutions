using System;

namespace GoltaraSolutions.Common.Infra.Dependency
{
    public interface IDependency
    {
        T Get<T>();
        object Get(Type type);
        void Bind<T>(T instance);
    }
}
