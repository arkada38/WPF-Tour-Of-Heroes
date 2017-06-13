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

        private Hero _hero;
        public Hero Hero => _hero ?? (_hero = new Hero() { Name = "Windstorm", Id = 1 });
    }
}
