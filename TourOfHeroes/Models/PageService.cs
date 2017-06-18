using System.Windows.Controls;
using TourOfHeroes.Utils;
using TourOfHeroes.Views;

namespace TourOfHeroes.Models
{
    public class PageService : ObservableObject
    {
        private Page _activePage;

        public Page ActivePage
        {
            get => _activePage ?? (_activePage = new DashboardView());
            set => SetField(ref _activePage, value);
        }

        private Page _previousPage;
        public Page PreviousPage
        {
            get => _previousPage ?? (_previousPage = new HeroDetailView());
            set => SetField(ref _previousPage, value);
        }

        public void Back()
        {
            ActivePage = PreviousPage;
        }
    }
}
