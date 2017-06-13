

using TourOfHeroes.Models;

namespace TourOfHeroes
{
    public static class Provider
    {
        private static HeroesFactory _heroesFactory;
        public static HeroesFactory HeroesFactory => _heroesFactory ?? (_heroesFactory = new HeroesFactory());
    }
}
