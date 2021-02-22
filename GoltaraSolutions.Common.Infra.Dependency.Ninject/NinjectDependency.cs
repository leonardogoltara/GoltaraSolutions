using Ninject;
using System;

namespace GoltaraSolutions.Common.Infra.Dependency.Ninject
{
    public class NinjectDependency : IDependency
    {
        private readonly StandardKernel _kernel;
        public NinjectDependency()
        {
            _kernel = new StandardKernel();
            _kernel.Bind<IDependency>().ToConstant(this);
        }
        public StandardKernel Kernel
        {
            get { return _kernel; }
        }

        public void Bind<T>(T constant)
        {
            _kernel.Bind<T>().ToConstant(constant);
        }

        public T Get<T>()
        {
            return _kernel.Get<T>();
        }

        public object Get(Type type)
        {
            return _kernel.Get(type);
        }
    }
}
