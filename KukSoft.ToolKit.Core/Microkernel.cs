using KukSoft.ToolKit.Logger;
using KukSoft.ToolKit.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using KukSoft.ToolKit.Utilities;

namespace KukSoft.ToolKit
{
    internal interface IMicrokernel
    {
        void Register<TContract, TImpl>() where TImpl : class;
        void Register<TContract, TImpl>(TImpl instance) where TImpl : class;

        TContract Resolve<TContract>();
        object Resolve(Type contract);
    }

    internal class Microkernel : IMicrokernel
    {
        private readonly IDictionary<Type, Type> _types = new Dictionary<Type, Type>();
        private readonly IDictionary<Type, object> _typeInstances = new Dictionary<Type, object>();

        public static IMicrokernel Instance => new Microkernel();

        protected Microkernel()
        {
            InitDefault();
        }

        private void InitDefault()
        {
            Register<IInflector, InflectorImpl>();
            Register<IGuard, GuardImpl>();
            Register<IPath, PathImpl>();
            Register<IFile, FileImpl>();

            Register<ILogger, StandardLogger>();
            Register<IEncryptionFactory, EncryptionFactory>();
        }

        public virtual void Register<TContract, TImplementation>() where TImplementation : class
        {
            _types[typeof(TContract)] = typeof(TImplementation);
        }

        public virtual void Register<TContract, TImplementation>(TImplementation instance) where TImplementation : class
        {
            _typeInstances[typeof(TContract)] = instance;
        }

        public virtual TContract Resolve<TContract>()
        {
            return (TContract)Resolve(typeof(TContract));
        }

        public virtual object Resolve(Type contract)
        {
            if (_typeInstances.ContainsKey(contract))
            {
                return _typeInstances[contract];
            }

            Type implementation = _types[contract];
            ConstructorInfo[] constructors = implementation.GetConstructors()
                .Where(c => c.IsPublic)
                .OrderByDescending(c => c.GetParameters().Length).ToArray();

            ConstructorInfo constructor = constructors[0];

            ParameterInfo[] constructorParameters = constructor.GetParameters();
            if (constructorParameters.Length == 0)
            {
                return Activator.CreateInstance(implementation);
            }
            List<object> parameters = new List<object>(constructorParameters.Length);
            foreach (ParameterInfo parameterInfo in constructorParameters)
            {
                parameters.Add(Resolve(parameterInfo.ParameterType));
            }
            return constructor.Invoke(parameters.ToArray());
        }
    }
}
