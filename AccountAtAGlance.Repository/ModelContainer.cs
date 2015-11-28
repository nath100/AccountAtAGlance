﻿using Microsoft.Practices.Unity;
using AccountAtAGlance.Repository;

namespace AccountAtAGlance.Model
{
    public static class ModelContainer
    {
        private static IUnityContainer _Instance;

        static ModelContainer()
        {
            _Instance = new UnityContainer();
        }

        public static IUnityContainer Instance
        {
            get
            {
                _Instance.RegisterType<IAccountRepository, AccountRepository>(new HierarchicalLifetimeManager());
                _Instance.RegisterType<ISecurityRepository, SecurityRepository>(new HierarchicalLifetimeManager());
                _Instance.RegisterType<IMarketsAndNewsRepository, MarketsAndNewsRepository>(new HierarchicalLifetimeManager());
                return _Instance;
            }
        }
    }
}
