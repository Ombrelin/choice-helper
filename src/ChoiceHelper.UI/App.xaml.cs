namespace ChoiceHelper.UI
{
    public partial class App : Application
    {
        public App(ChoicesListPage mainPage)
        {
            InitializeComponent();
            MainPage = new NavigationPage(mainPage);
        }
    }
}