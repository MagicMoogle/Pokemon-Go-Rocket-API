using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo.RocketAPI.Window
{
    public enum Status
    {
        Inactive,
        LoggingIn,
        ScanningPokestops,
        MovingToPokestop,
        ScanningPokemon,
        MovingToPokemon,
        CatchingPokemon,
        TransferringPokemon,
        EvolvingPokemon,
        RecyclingItems
    }
}
