using System.Collections.ObjectModel;
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
        public Hero Hero
        {
            get => Provider.HeroesFactory.Hero;
            set => Provider.HeroesFactory.Hero = value;
        }

        public ObservableCollection<Hero> Heroes => Provider.HeroesFactory.Heroes;
    }
}
