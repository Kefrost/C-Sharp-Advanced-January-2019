using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {
        private List<Hero> data;

        public HeroRepository()
        {
            data = new List<Hero>();
        }

        public int Count { get => this.data.Count; }

        public void Add(Hero hero)
        {
            data.Add(hero);
        }

        public void Remove(string name)
        {
            var heroToRemove = data.Find(x => x.Name == name);
            data.Remove(heroToRemove);
        }

        public Hero GetHeroWithHighestStrength()
        {
            int index = 0;
            int max = 0;
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Item.Strength > max)
                {
                    max = data[i].Item.Strength;
                    index = i;
                }
            }

            return data[index];
        }

        public Hero GetHeroWithHighestAbility()
        {
            int index = 0;
            int max = 0;
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Item.Ability > max)
                {
                    max = data[i].Item.Ability;
                    index = i;
                }
            }

            return data[index];
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            int index = 0;
            int max = 0;
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Item.Intelligence > max)
                {
                    max = data[i].Item.Intelligence;
                    index = i;
                }
            }

            return data[index];
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, data);
        }
    }
}
