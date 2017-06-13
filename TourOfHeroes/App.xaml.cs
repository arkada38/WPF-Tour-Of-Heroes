using System.Windows;
using TourOfHeroes.Views;

namespace TourOfHeroes
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            new MainView().Show();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            TourOfHeroes.Properties.Settings.Default.Save();
            base.OnExit(e);
        }
    }
}
