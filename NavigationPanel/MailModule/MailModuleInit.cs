using Infrastructure;
using Microsoft.Practices.Unity;
using Prism.Events;
using Prism.Modularity;
using Prism.Regions;
using System;

namespace MailModule
{
	public class MailModuleInit : IModule
	{
		private IRegionManager _regionManager;

		private IUnityContainer _container;

        private IEventAggregator _eventAggregrator;

        public MailModuleInit(IUnityContainer container,
            IRegionManager regionManager,
            IEventAggregator eventAggregrator)
		{
			_regionManager = regionManager;

			_container = container;

            _eventAggregrator = eventAggregrator;
        }

		public void Initialize()
		{
            _regionManager.RegisterViewWithRegion(RegionNames.NavigationSectionRegion, typeof(MailNavigationSection));
        }
    }
}
