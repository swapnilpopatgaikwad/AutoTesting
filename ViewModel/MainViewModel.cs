using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AutoTesting.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private string userName = "";

        [ObservableProperty]
        private string displayUserName = "";

        public MainViewModel()
        {
        }

        [RelayCommand]
        private void ClickButton()
        {
            DisplayUserName = UserName;
        }
    }
}
