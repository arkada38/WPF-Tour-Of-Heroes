using TourOfHeroes.Utils;

namespace TourOfHeroes.Models
{
    public class Hero : ObservableObject
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => SetField(ref _name, value);
        }

        private int _id;
        public int Id
        {
            get => _id;
            set => SetField(ref _id, value);
        }
    }
}
