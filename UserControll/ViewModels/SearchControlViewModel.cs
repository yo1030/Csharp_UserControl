namespace UserControll.ViewModels
{
    public class SearchControlViewModel : ViewModelBase
    {
        public SearchControlViewModel()
        {
            
        }

        private string _searchTextBoxText = "----";
        public string SearchTextBoxText
        {
            get { return _searchTextBoxText; }
            set
            {
                SetProperty(ref _searchTextBoxText, value);
            }
        }

        public event Action<string> BackAction;

        internal void Back()
        {
            BackAction?.Invoke(SearchTextBoxText);
        }
    }
}
