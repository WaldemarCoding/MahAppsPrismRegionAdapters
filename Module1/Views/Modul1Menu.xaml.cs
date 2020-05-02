using MahApps.Metro.Controls;
using PrismApp.Core;

namespace Module1.Views
{
    /// <summary>
    /// Interaction logic for AccordionMenuItem.xaml
    /// </summary>
    public partial class Modul1Menu : HamburgerMenuItemCollection, IMenuRootItem
    {
        public Modul1Menu()
        {
            InitializeComponent();
        }

        public string DefaultNavigationPath => nameof(ViewA);
    }
}
