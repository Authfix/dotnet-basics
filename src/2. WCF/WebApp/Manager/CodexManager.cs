using MyCompany.Codex.Dtos;
using MyCompany.Codex.WebApp.Entities;
using System;
using System.Collections.Generic;

namespace MyCompany.Codex.WebApp.Managers
{
    internal class CodexManager
    {
        /// <summary>
        /// Gets the creatures from the codex
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CreatureDto> GetCreatures()
        {
            var creatures = new List<Creature>() { new Creature(Guid.NewGuid())};

            foreach (var creature in creatures)
            {
                yield return new CreatureDto { Id = creature.Id };
            }
        }
    }
}