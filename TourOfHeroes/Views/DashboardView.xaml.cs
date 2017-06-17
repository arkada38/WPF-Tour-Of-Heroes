using System.Collections.ObjectModel;
using System.Linq;
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
        #region Fields and Properties
        public HeroesFactory HeroesFactory => Provider.HeroesFactory;
        public PageService PageService => Provider.PageService;

        private string _filter;
        public string Filter
        {
            get => _filter;
            set
            {
                SetField(ref _filter, value);
                OnFilterChanged();
            }
        }

        private ObservableCollection<Hero> _filteredHeroes;
        public ObservableCollection<Hero> FilteredHeroes
        {
            get => _filteredHeroes;
            set => SetField(ref _filteredHeroes, value);
        }

        private Hero _selectedFilteredHero;
        public Hero SelectedFilteredHero
        {
            get => _selectedFilteredHero;
            set
            {
                if (string.IsNullOrWhiteSpace(value?.Name)) return;
                SetField(ref _selectedFilteredHero, value);

                var heroDetailViewModel = new HeroDetailViewModel(value);
                PageService.PreviousPage = PageService.ActivePage;
                PageService.ActivePage = new HeroDetailView { DataContext = heroDetailViewModel };
                Filter = string.Empty;
            }
        }

        #endregion

        public RelayCommand ShowHeroDetail =>
            new RelayCommand(h =>
            {
                if (h == null) return;
                var heroDetailViewModel = new HeroDetailViewModel(h as Hero);
                PageService.PreviousPage = PageService.ActivePage;
                PageService.ActivePage = new HeroDetailView { DataContext = heroDetailViewModel };
            });

        private void OnFilterChanged()
        {
            if (string.IsNullOrWhiteSpace(Filter))
                FilteredHeroes = null;
            else
                FilteredHeroes = new ObservableCollection<Hero>(
                    HeroesFactory.Heroes.Where(hero => hero.Name.ToLower().Contains(Filter.ToLower()))
                );
        }
    }
}
