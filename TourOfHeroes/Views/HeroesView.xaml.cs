using System.Linq;
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

        private Hero _newHero;
        public Hero NewHero
        {
            get => _newHero ?? (_newHero = new Hero {Id = HeroesFactory.Heroes.Last().Id + 1});
            set => SetField(ref _newHero, value);
        }

        public RelayCommand AddNewHero =>
            new RelayCommand(() =>
            {
                HeroesFactory.Heroes.Add(NewHero);
                NewHero = null;
            }, o => !string.IsNullOrEmpty(NewHero.Name));
    }
}
