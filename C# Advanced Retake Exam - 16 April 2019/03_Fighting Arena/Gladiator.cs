using System;
using System.Collections.Generic;
using System.Text;

namespace FightingArena
{
    public class Gladiator
    {
        public string Name { get; private set; }
        public Stat Stat { get; private set; }
        public Weapon Weapon { get; private set; }

        public Gladiator(string name,Stat stat,Weapon weapon )
        {
            this.Name = name;
            this.Stat = stat;
            this.Weapon = weapon;
        }

        public int GetTotalPower()
        {
            int total = this.Stat.Agility + this.Stat.Flexibility + this.Stat.Intelligence + this.Stat.Skills + this.Stat.Strength + this.Weapon.Sharpness + this.Weapon.Size + this.Weapon.Solidity;
            return total;
        }

        public int GetWeaponPower()
        {
            int total = this.Weapon.Sharpness + this.Weapon.Size + this.Weapon.Solidity;
            return total;
        }

        public int GetStatPower()
        {
            int total = this.Stat.Agility + this.Stat.Flexibility + this.Stat.Intelligence + this.Stat.Skills + this.Stat.Strength;
            return total;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Name} - {GetTotalPower()}");
            sb.AppendLine($"  Weapon Power: {GetWeaponPower()}");
            sb.AppendLine($"  Stat Power: {GetStatPower()}");

            return sb.ToString().TrimEnd();
        }
    }
}
