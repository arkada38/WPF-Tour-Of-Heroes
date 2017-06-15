using System.Windows.Controls;
using TourOfHeroes.MVVM;
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
    }
}
