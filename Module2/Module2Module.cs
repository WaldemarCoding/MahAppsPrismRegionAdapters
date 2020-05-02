using Module2.ViewModels;
using Module2.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismApp.Core;

namespace Module2
{
    public class Module2Module : IModule
    {
        private readonly IRegionManager _regionManager;

        public Module2Module(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.MenuRegion, typeof(Modul2Menu));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewC, ViewCViewModel>();
        }
    }
}