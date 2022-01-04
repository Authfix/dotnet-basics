using MyCompany.Codex.WebApp.Dtos;
using MyCompany.Codex.WebApp.Managers;
using System.Collections.Generic;

namespace MyCompany.Codex.WebApp
{
    public class CodexService : ICodexService
    {
        private readonly CodexManager _codexManager;

        /// <summary>
        /// Initialize a new <see cref="CodexService"/>
        /// </summary>
        public CodexService()
        {
            _codexManager = new CodexManager();
        }

        /// <summary>
        /// Gets codex creatures
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Creature> GetCreatures()
        {
            return _codexManager.GetCreatures();
        }
    }
}
