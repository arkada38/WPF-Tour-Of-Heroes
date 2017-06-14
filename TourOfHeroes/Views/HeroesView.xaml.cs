using TourOfHeroes.Models;
using TourOfHeroes.MVVM;

namespace TourOfHeroes.Views
{
    public partial class HeroesView
    {
        public HeroesView()
        {
            InitializeComponent();
        }
    }

    public class HeroesViewModel : ObservableObject
    {
        public HeroesFactory HeroesFactory => Provider.HeroesFactory;
    }
}
