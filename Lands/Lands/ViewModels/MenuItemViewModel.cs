namespace Lands.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;

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

        private  void Navigate()
        {
            if (this.PageName=="LoginPage")
            {
                Application.Current.MainPage = new LoginPage();
            }            
        }
        #endregion
    }
}
