using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Hero
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        public Item Item { get; private set; }

        public Hero(string name, int level, Item item)
        {
            this.Name = name;
            this.Level = level;
            this.Item = item;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Hero: {this.Name} – {this.Level}lvl");
            sb.AppendLine($"Item:");
            sb.AppendLine($"  * Strength: {this.Item.Strength}");
            sb.AppendLine($"  * Ability: {this.Item.Ability}");
            sb.AppendLine($"  * Intelligence: {this.Item.Intelligence}");

            return sb.ToString().TrimEnd();
        }
    }
}
