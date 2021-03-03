using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace appDataGrid
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            await vm.LoadDataAsync();
        }

        public ViewModel vm { get; } = new ViewModel();

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            var i = vm.SelectedItem as ViewModel.ItemData;
            if (i == null) return;
            var s = new ViewModel.ItemData();
            s.Data1 = i.Data1;
            s.Status = i.Status;
            vm.Source.Add(s);

        }

        private void ButtonDel_Click(object sender, RoutedEventArgs e)
        {
            if (vm.DataTableSelectedIndex < 0) return;
            vm.Source.RemoveAt(vm.DataTableSelectedIndex);
        }

        private void DataGrid_LoadingRow(object sender, Microsoft.Toolkit.Uwp.UI.Controls.DataGridRowEventArgs e)
        {

        }

    }
}
