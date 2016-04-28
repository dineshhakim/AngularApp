using AngularApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularApp.Managers
{
    public class HeroManager
    {
        readonly List<Hero> _heroes = new List<Hero>() {
            new Hero { ID = 1, Name = "Bristleback", Type="Strength"},
            new Hero { ID = 2, Name ="Abbadon", Type="Strength"},
            new Hero { ID = 3, Name ="Spectre", Type="Agility"},
            new Hero { ID = 4, Name ="Juggernaut", Type="Agility"},
            new Hero { ID = 5, Name ="Lion", Type="Intelligence"},
            new Hero { ID = 6, Name ="Zues", Type="Intelligence"},
            new Hero { ID = 7, Name ="Trent", Type="Strength"},
        };
        public IEnumerable<Hero> GetAll { get { return _heroes; } }

        public List<Hero> GetHeroesByType(string type)
        {
            return _heroes.Where(o => o.Type.ToLower().Equals(type.ToLower())).ToList();
        }

        public Hero GetHeroByID(int Id)
        {
            return _heroes.Find(o => o.ID == Id);
        }
    }
}
