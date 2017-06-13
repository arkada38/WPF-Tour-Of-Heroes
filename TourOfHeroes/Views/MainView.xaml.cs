using System.Collections.ObjectModel;
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
        public ObservableCollection<Hero> Heroes => Provider.HeroesFactory.Heroes;

        private Hero _hero;
        public Hero Hero
        {
            get => _hero;
            set => SetField(ref _hero, value);
        }
    }
}
