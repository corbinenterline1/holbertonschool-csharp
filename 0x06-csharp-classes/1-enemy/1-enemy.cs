using System;

namespace Enemies
{
    /// <summary>
    /// Represents a brain-eating ghoul.
    /// </summary>
    public class Zombie 
    {
        /// <summary>
        /// Represents the health of the Zombie object.
        /// This public field is a member of the Zombie class.
        /// </summary>
        public int health;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }
    }
}