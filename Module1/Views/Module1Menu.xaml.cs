using MahApps.Metro.Controls;
using PrismApp.Core;

namespace Module1.Views
{
    /// <summary>
    /// Interaction logic for AccordionMenuItem.xaml
    /// </summary>
    public partial class Module1Menu : HamburgerMenuItemCollection, IMenuRootItem
    {
        public Module1Menu()
        {
            InitializeComponent();
        }

        public string DefaultNavigationPath => nameof(ViewA);
    }
}
