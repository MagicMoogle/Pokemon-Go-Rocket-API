using PokemonGo.RocketAPI.GeneratedCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo.RocketAPI.Window
{
    class PokemonListViewArg : EventArgs
    {
        public ulong ID { get; }
        public string Name { get; }
        public int CP { get; }
        public int Attack { get; }
        public int Defense { get; }
        public int Stamina { get; }
        public int IV { get; }

        public PokemonListViewArg(ulong id, string name, int cp, int attack, int defense, int stamina, int iv)
        {
            this.ID = id;
            this.Name = name;
            this.CP = cp;
            this.Attack = attack;
            this.Defense = defense;
            this.Stamina = stamina;
            this.IV = iv;
        }
    }
}
