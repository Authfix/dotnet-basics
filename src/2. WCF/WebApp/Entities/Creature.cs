using System;

namespace MyCompany.Codex.WebApp.Entities
{
    internal class Creature
    {
        /// <summary>
        /// Initialize a new <see cref="Creature"/>
        /// </summary>
        /// <param name="id">The creature identifier</param>
        /// <exception cref="ArgumentOutOfRangeException">If the guid is empty</exception>
        public Creature(Guid id)
        {
            if (id == Guid.Empty) throw new ArgumentOutOfRangeException(nameof(id));
            
            Id = id;
        }

        private Guid _id;
        /// <summary>
        /// Gets the creature identifier
        /// </summary>
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}