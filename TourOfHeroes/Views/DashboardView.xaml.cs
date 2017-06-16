using System;
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
        public PageService PageService => Provider.PageService;

        public RelayCommand ShowHeroDetail =>
            new RelayCommand(h =>
            {
                if (h == null) return;
                var heroDetailViewModel = new HeroDetailViewModel(h as Hero);
                PageService.PreviousPage = PageService.ActivePage;
                PageService.ActivePage = new HeroDetailView { DataContext = heroDetailViewModel };
            });
    }
}
