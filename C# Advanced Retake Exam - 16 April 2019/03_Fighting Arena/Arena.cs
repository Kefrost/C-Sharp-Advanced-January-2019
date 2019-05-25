using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FightingArena
{
    public class Arena
    {
        private List<Gladiator> gladiators;

        public int Count { get => gladiators.Count; }

        public Arena(string name)
        {
            gladiators = new List<Gladiator>();
            this.Name = name;
        }

        public string Name { get; private set; }

        public void Add(Gladiator gladiator)
        {
            gladiators.Add(gladiator);
        }

        public void Remove(string name)
        {
            Gladiator gladiator = gladiators.Find(g => g.Name == name);

            gladiators.Remove(gladiator);
        }

        public Gladiator GetGladitorWithHighestStatPower()
        {
            int max = 0;
            Gladiator gladiator = null;
            foreach (var item in gladiators)
            {
                int curr = item.GetStatPower();

                if (curr > max)
                {
                    gladiator = item;
                }
            }
            return gladiator;
        }

        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            int max = 0;
            Gladiator gladiator = null;
            foreach (var item in gladiators)
            {
                int curr = item.GetWeaponPower();

                if (curr > max)
                {
                    gladiator = item;
                }
            }
            return gladiator;
        }

        public Gladiator GetGladitorWithHighestTotalPower()
        {
            int max = 0;
            Gladiator gladiator = null;
            foreach (var item in gladiators)
            {
                int curr = item.GetTotalPower();

                if (curr > max)
                {
                    gladiator = item;
                }
            }
            return gladiator;
        }

        public override string ToString()
        {

            return $"{this.Name} - {this.Count} gladiators are participating.";
        }

    }
}
