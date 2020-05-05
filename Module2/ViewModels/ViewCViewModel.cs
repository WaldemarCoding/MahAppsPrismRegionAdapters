using System.Linq;
using Module2.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using PrismApp.Core;

namespace Module2.ViewModels
{
    public class ViewCViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewCViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            Message = "View C from Module 2";
        }

        private DelegateCommand _removeMenuCommand;
        public DelegateCommand RemoveMenuCommand => _removeMenuCommand ?? (_removeMenuCommand = new DelegateCommand(ExecuteCommandName));

        void ExecuteCommandName()
        {
            var rmR = _regionManager.Regions[RegionNames.MenuRegion];
            var view = rmR.ActiveViews.FirstOrDefault<dynamic>(v => v.DependencyObjectType.Name == "Module2Menu");

            if (view != null)
            {
                rmR.Remove(view);
            }
        }
    }
}
