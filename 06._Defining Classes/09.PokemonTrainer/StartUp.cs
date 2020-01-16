using System;
using System.Linq;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // "{trainerName} {pokemonName} {pokemonElement} {pokemonHealth}"
            var trainers = new Dictionary<string, Trainer>();

            string command = Console.ReadLine();

            while (command != "Tournament")
            {
                var tokkens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var trainerName = tokkens[0];
                var pokemonName = tokkens[1];
                var pokemonElement = tokkens[2];
                var pokemonHealth = int.Parse(tokkens[3]);

                var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName));
                }

                trainers[trainerName].Pokemons.Add(pokemon);

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                var element = command;
                foreach (var trainer in trainers.Values)
                {
                    if (trainer.Pokemons.Any(x => x.Element == element))
                    {
                        trainer.NumberOfBadges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                    }
                }
                foreach (Trainer trainer in trainers.Values)
                {
                    for (int i = 0; i < trainer.Pokemons.Count; i++)
                    {
                        if (trainer.Pokemons[i].Health <= 0)
                        {
                            trainer.Pokemons.RemoveAt(i);
                        }
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var trainer in trainers.Values.OrderByDescending(x =>x.NumberOfBadges))
            {
                Console.WriteLine(trainer);
            }
        }
    }
}
