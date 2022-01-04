using MyCompany.Codex.WebApp.Dtos;
using System.Collections.Generic;

namespace MyCompany.Codex.WebApp.Managers
{
    public class CodexManager
    {
        /// <summary>
        /// Gets the creatures from the codex
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Creature> GetCreatures()
        {
            return new List<Creature>() { new Creature { Id = System.Guid.NewGuid() }};
        }
    }
}