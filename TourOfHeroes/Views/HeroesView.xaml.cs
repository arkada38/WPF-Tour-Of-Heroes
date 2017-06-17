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
        #region Fields and Properties
        public HeroesFactory HeroesFactory => Provider.HeroesFactory;

        private Hero _selectedHero;
        public Hero SelectedHero
        {
            get => _selectedHero;
            set => SetField(ref _selectedHero, value);
        }

        private Hero _newHero;
        public Hero NewHero
        {
            get => _newHero ?? (_newHero = new Hero {Id = HeroesFactory.Heroes.Last().Id + 1});
            set => SetField(ref _newHero, value);
        }
        #endregion

        #region Commands
        public RelayCommand AddNewHero =>
            new RelayCommand(() =>
            {
                HeroesFactory.Heroes.Add(NewHero);
                NewHero = null;
            }, o => !string.IsNullOrWhiteSpace(NewHero.Name));

        public RelayCommand ViewDetails =>
            new RelayCommand(() =>
            {
                var heroDetailViewModel = new HeroDetailViewModel(SelectedHero);
                Provider.PageService.PreviousPage = Provider.PageService.ActivePage;
                Provider.PageService.ActivePage = new HeroDetailView { DataContext = heroDetailViewModel };
            }, o => SelectedHero != null);

        public RelayCommand RemoveHero =>
            new RelayCommand(h =>
            {
                HeroesFactory.Heroes.Remove((Hero) h);
            });
        #endregion
    }
}
