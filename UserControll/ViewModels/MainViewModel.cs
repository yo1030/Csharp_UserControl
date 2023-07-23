namespace UserControll.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
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

        public SearchControlViewModel SearchControlViewModel { get; set; } = new SearchControlViewModel();

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
