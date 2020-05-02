using Prism.Mvvm;

namespace Module1.ViewModels
{
    public class ViewBViewModel : BindableBase
    {
        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewBViewModel()
        {
            Message = "View B from Module 1";
        }
    }
}
