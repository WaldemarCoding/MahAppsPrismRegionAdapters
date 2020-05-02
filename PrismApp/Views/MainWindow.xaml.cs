using System.Windows;
using MahApps.Metro.Controls;
using Prism.Regions;
using PrismApp.Core;

namespace PrismApp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private readonly IApplicationCommands _applicationCommands;

        public MainWindow(IApplicationCommands applicationCommands, IRegionManager regionManager)
        {
            _applicationCommands = applicationCommands;
            InitializeComponent();
            RegionManager.SetRegionName(HamburgerMenuContent, RegionNames.ContentRegion);
            RegionManager.SetRegionManager(HamburgerMenuContent, regionManager);
        }

        private void HamburgerMenuControl_OnItemClick(object sender, ItemClickEventArgs args)
        {
            if (((HamburgerMenu)sender).SelectedItem is HamburgerMenuItem child)
            {
                if (child.CommandParameter is string path)
                {
                    _applicationCommands.NavigateCommand.Execute(path);
                }
            }
        }

        private void HamburgerMenuControl_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (((HamburgerMenu)sender).SelectedItem is IMenuRootItem root)
            {
                _applicationCommands.NavigateCommand.Execute(root.DefaultNavigationPath);
            }
        }
    }
}
