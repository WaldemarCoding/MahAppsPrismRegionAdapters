using Prism.Ioc;
using PrismApp.Views;
using System.Windows;
using MahApps.Metro.Controls;
using Module1;
using Module2;
using Prism.Modularity;
using Prism.Regions;
using PrismApp.Core;
using PrismApp.Core.RegionAdapters;

namespace PrismApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IApplicationCommands, ApplicationCommands>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<Module1Module>();
            moduleCatalog.AddModule<Module2Module>();
        }

        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            // Custom Adapters
            regionAdapterMappings.RegisterMapping(typeof(HamburgerMenu), Container.Resolve<MahAppsHamburgerMenuRegionAdapter>());
        }
    }
}
