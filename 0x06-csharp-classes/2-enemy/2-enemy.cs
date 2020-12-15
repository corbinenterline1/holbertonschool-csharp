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
        /// This public property is a member of the Zombie class.
        /// </summary>
        public int health;

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// </summary>
        public Zombie()
        {
            this.health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Zombie"/> class.
        /// Sets the value of this Zombie's health, which must be greater than or equal to 0.
        /// </summary>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            this.health = value;
        }
    }
}