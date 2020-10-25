using ContactModule;
using Infrastructure;
using Microsoft.Practices.Unity;
using Prism.Events;
using Prism.Modularity;
using Prism.Regions;
using System;

namespace CatalogModule
{
	public class CatalogModuleInit : IModule
	{
		private IRegionManager _regionManager;

		private IUnityContainer _container;

        private IEventAggregator _eventAggregrator;

        public CatalogModuleInit(IUnityContainer container,
            IRegionManager regionManager,
            IEventAggregator eventAggregrator)
		{
			_regionManager = regionManager;

			_container = container;

            _eventAggregrator = eventAggregrator;
        }

		public void Initialize()
		{
            _regionManager.RegisterViewWithRegion(RegionNames.NavigationSectionRegion, typeof(ContactNavigationSection));
        }
    }
}
