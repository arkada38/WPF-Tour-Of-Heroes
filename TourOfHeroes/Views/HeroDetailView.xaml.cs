using TourOfHeroes.Models;
using TourOfHeroes.Utils;

namespace TourOfHeroes.Views
{
    public partial class HeroDetailView
    {
        public HeroDetailView()
        {
            InitializeComponent();
        }
    }

    public class HeroDetailViewModel : ObservableObject
    {
        #region Fields and Properties
        private Hero _initialHero;
        public Hero InitialHero
        {
            get => _initialHero;
            set => SetField(ref _initialHero, value);
        }

        private Hero _hero;
        public Hero Hero
        {
            get => _hero;
            set => SetField(ref _hero, value);
        }
        #endregion

        #region Commands
        public RelayCommand Save =>
            new RelayCommand(() =>
            {
                InitialHero.Name = Hero.Name;
                Provider.PageService.Back();
            });
        
        public RelayCommand Back =>
            new RelayCommand(Provider.PageService.Back);
        #endregion

        public HeroDetailViewModel(Hero hero)
        {
            InitialHero = hero;
            
            Hero = new Hero
            {
                Id = InitialHero.Id,
                Name = InitialHero.Name
            };
        }
    }
}
