using System.Collections.ObjectModel;

namespace PrismApp.Core
{
    public class NavigationItem
    {
        // Don't rename, this one has to be named Header as AccordionControl can only have one
        // DisplayMemberPath and Root Level is set by Header
        public string Label { get; set; }
        public string NavigationPath { get; set; }

        public ObservableCollection<NavigationItem> Items { get; set; } = new ObservableCollection<NavigationItem>();
    }
}
