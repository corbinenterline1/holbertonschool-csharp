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
        /// This private field is a member of the Zombie class.
        /// </summary>
        private int health;

        /// <summary>
        /// Represents the name of the Zombie object.
        /// </summary>
        private string name = "(No name)";

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

        /// <summary>
        /// Gets the value of heatlh of the Zombie object.
        /// </summary>
        public int GetHealth()
        {
            return this.health;
        }
        
        /// <summary>
        /// Gets or sets a value indicating the name of the Zombie object.
        /// </summary>
        public string Name
        {
            get => this.name;
            set
            {
                this.name = value;
            }
        }
        
        /// <summary>
        /// Returns the Zombie object's attributes.
        /// </summary>
        public override string ToString()
        {
            return String.Format("Zombie Name: {0} / Total Health: {1}", this.name, this.health);
        }
    }
}