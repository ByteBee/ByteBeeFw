using System;
using System.Collections.Generic;
using ByteBee.DotNetWrapper;
using ByteBee.DotNetWrapper.Impl;
using ByteBee.Exceptions;
using ByteBee.Logging;
using ByteBee.Logging.Impl;

namespace ByteBee
{
    public static class BeeKernel
    {
        private static Dictionary<Type, Func<object>> _factory = new Dictionary<Type, Func<object>>();
        private static Dictionary<Type, object> _instances = new Dictionary<Type, object>();

        static BeeKernel()
        {
            InitDefaults();
        }

        private static void InitDefaults()
        {
            Register<ILogger>(() => new StandardLogger());
            Register<IPathWrapper>(() => new PathWrapperImpl());
            Register<IFileWrapper>(() => new FileWrapperImpl());
        }
        
        
        public static void Register<TContract>(Func<TContract> registration) where TContract : class
        {
            Type contractType = typeof(TContract);

            if (!_factory.ContainsKey(contractType))
            {
                _factory.Add(contractType, registration);
            }
            else
            {
                _factory[contractType] = registration;
            }
        }

        public static TContract GetNew<TContract>()
        {
            Type requestedType = typeof(TContract);

            if (_factory.ContainsKey(requestedType))
            {
                // todo
                throw new ByteBeeException($"could not find an instance of type {requestedType.FullName}");
            }

            object instance = _factory[requestedType]();
            return (TContract) instance;
        }

        public static TContract GetExisting<TContract>()
        {
            Type requestedType = typeof(TContract);

            if (_instances.ContainsKey(requestedType))
            {
                return (TContract)_instances[requestedType];
            }

            TContract newInstance = GetNew<TContract>();

            _instances.Add(requestedType, newInstance);

            return newInstance;
        }
    }
}