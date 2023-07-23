using UserControll.Domain;

namespace UserControll.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(IProductRepository repository)
        {
            SearchControlViewModel = new SearchControlViewModel(repository);
            SearchControlViewModel.BackAction += SearchControlViewModel_BackAction;
        }

        private string _aaaTextBox = "aabbcc";
        public string AAATextBoxText
        {
            get { return _aaaTextBox; }
            set
            {
                SetProperty(ref _aaaTextBox, value);
            }
        }

        public SearchControlViewModel SearchControlViewModel { get; set; }

        internal void Call()
        {
            SearchControlViewModel.SearchTextBoxText = AAATextBoxText;
        }

        private void SearchControlViewModel_BackAction(string obj)
        {
            AAATextBoxText = obj;
        }
    }
}
