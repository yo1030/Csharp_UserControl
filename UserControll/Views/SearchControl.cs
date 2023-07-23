using UserControll.ViewModels;

namespace UserControll.Views
{
    public partial class SearchControl : UserControl
    {
        private SearchControlViewModel _vm;
        public SearchControl()
        {
            InitializeComponent();
        }

        public void SetViewModel(SearchControlViewModel vm)
        {
            _vm = vm;
            SearchTextBox.DataBindings.Add("Text", _vm, nameof(_vm.SearchTextBoxText));

            BackButton.Click += (_, __) => _vm.Back();
            ProductDataGrid.DataSource = _vm.DataGrid;
        }
    }
}
