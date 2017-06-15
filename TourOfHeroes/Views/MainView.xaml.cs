using TourOfHeroes.Models;
using TourOfHeroes.MVVM;

namespace TourOfHeroes.Views
{
    public partial class MainView
    {
        public MainView()
        {
            InitializeComponent();
        }
    }

    public class MainViewModel : ObservableObject
    {
        public string Title => "Tour of Heroes";

        public PageService PageService => Provider.PageService;

        public RelayCommand OpenUrl =>
            new RelayCommand(() =>
            System.Diagnostics.Process.Start("https://angular.io/tutorial" + ""));

        public RelayCommand SetHeroesPage =>
            new RelayCommand(() =>
                PageService.ActivePage = new HeroesView());

        public RelayCommand SetDashboardPage =>
            new RelayCommand(() =>
                PageService.ActivePage = new DashboardView());
    }
}
