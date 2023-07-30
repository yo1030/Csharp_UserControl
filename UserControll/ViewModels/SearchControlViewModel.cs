using System.ComponentModel;
using UserControll.Domain;

namespace UserControll.ViewModels
{
    public class SearchControlViewModel : ViewModelBase
    {
        private readonly IProductRepository _repository;
        public SearchControlViewModel(IProductRepository repository)
        {
            _repository = repository;
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

        public BindingList<SearchControlViewModelGrid> DataGrid
        { get; set; } = new BindingList<SearchControlViewModelGrid>();

        public event Action<string> BackAction;

        internal void Back()
        {
            BackAction?.Invoke(SearchTextBoxText);
            DataGrid.Clear();
            var entities = _repository.GetAll();
            foreach (var entity in entities)
            {
                DataGrid.Add(new SearchControlViewModelGrid(entity));
            }
        }
    }
}
