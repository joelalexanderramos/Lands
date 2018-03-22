namespace Lands
{
    using Xamarin.Forms;
    using Views;
    using Helpers;
    using ViewModels;
    using Services;
    using Lands.Models;

    public partial class App : Application
	{
        #region Properties
        public static NavigationPage Navigator {get; internal set; }

        public static MasterPage Master { get; internal set; }
        #endregion

        #region Constructor
        public App ()
		{
			InitializeComponent();

            if (string.IsNullOrEmpty(Settings.TokenType))
            {
                this.MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                var dataService = new DataService();
                var user = dataService.First<UserLocal>(false);

                var mainViewModel = MainViewModel.GetInstance();
                mainViewModel.Token = Settings.Token;
                mainViewModel.TokenType = Settings.TokenType;
                mainViewModel.User = user;
                mainViewModel.Lands = new LandsViewModel();

                this.MainPage = new MasterPage();
            }
            
            //this.MainPage = new MasterPage();
		}
        #endregion

        #region Methods
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        } 
        #endregion
    }
}
