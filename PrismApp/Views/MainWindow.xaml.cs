using MahApps.Metro.Controls;
using PrismApp.Core;

namespace PrismApp.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private readonly IApplicationCommands _applicationCommands;

        public MainWindow(IApplicationCommands applicationCommands)
        {
            _applicationCommands = applicationCommands;
            InitializeComponent();
        }

        private void HamburgerMenuControl_OnItemClick(object sender, ItemClickEventArgs args)
        {
            if (((HamburgerMenu)sender).SelectedItem is NavigationItem child)
            {
                if (!string.IsNullOrEmpty(child.NavigationPath))
                {
                    _applicationCommands.NavigateCommand.Execute(child.NavigationPath);
                }
            }
        }

    }
}
