using UserControll.ViewModels;

namespace UserControll.Views
{
    public partial class MainView : Form
    {
        private MainViewModel _vm = new MainViewModel();
        public MainView()
        {
            InitializeComponent();

            searchControl.SetViewModel(_vm.SearchControlViewModel);

            AAATextBox.DataBindings.Add("Text", _vm, nameof(_vm.AAATextBoxText));

            CallButton.Click += (_, __) => _vm.Call();
        }
    }
}
