namespace Lands.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;
    using Lands.Helpers;

    public class MenuItemViewModel
    {
        public string Icon { get; set; }

        public string Title { get; set; }

        public string PageName { get; set; }

        #region Commands
        public ICommand NavigateCommand
        {
            get
            {
                return new RelayCommand(Navigate);
            }
        }

        private void Navigate()
        {
            App.Master.IsPresented = false;

            if (this.PageName=="LoginPage")
            {
                // Al darle logout, limpiar variables de persistencia
                Settings.Token = string.Empty;
                Settings.TokenType = string.Empty;

                // También limpiar los valores de la MainViewModel
                var mainViewModel = MainViewModel.GetInstance();
                mainViewModel.Token = string.Empty;
                mainViewModel.TokenType = string.Empty;

                Application.Current.MainPage = new NavigationPage(new LoginPage());
            }
            else if (this.PageName == "MyProfilePage")
            {
                // Siempre, antes de navegar, se debe instanciar la view model correspondiente a la página.
                MainViewModel.GetInstance().MyProfile = new MyProfileViewModel();
                App.Navigator.PushAsync(new MyProfilePage());
            }            
        }
        #endregion
    }
}
