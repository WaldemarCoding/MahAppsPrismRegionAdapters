using Prism.Mvvm;

namespace Module2.ViewModels
{
    public class ViewCViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewCViewModel()
        {
            Message = "View C from Module 2";
        }
    }
}
