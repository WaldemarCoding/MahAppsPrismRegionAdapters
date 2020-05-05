using Module1.ViewModels;
using Module1.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismApp.Core;

namespace Module1
{
    public class Module1Module : IModule
    {
        private readonly IRegionManager _regionManager;

        public Module1Module(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion(RegionNames.MenuRegion, typeof(Module1Menu));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA, ViewAViewModel>();
            containerRegistry.RegisterForNavigation<ViewB, ViewBViewModel>();
        }
    }
}