using TourOfHeroes.Models;
using TourOfHeroes.MVVM;

namespace TourOfHeroes.Views
{
    public partial class DashboardView
    {
        public DashboardView()
        {
            InitializeComponent();
        }
    }

    public class DashboardViewModel : ObservableObject
    {
        public HeroesFactory HeroesFactory => Provider.HeroesFactory;
    }
}
