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
            new RelayCommand(i =>
                PageService.ActivePage = new HeroDetailView { DataContext = HeroesFactory.Heroes[Convert.ToInt32(i)] });
    }
}
