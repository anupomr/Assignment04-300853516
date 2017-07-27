using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Anupom Roy
 * Date: July 25, 2017
 * Description: This is the TerrestrialPlanet class which inherits from the Planet class
 * and implements the IHasMoons, IHabitable
 * Version: 0.1 -TerrestrialPlanet class Created.
 */
namespace Assignment04_300853516
{
    /// <summary>
    /// This is the TerrestrialPlanet sub class.
    /// It inherits from the Planet Superclass.
    /// </summary>
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        // PRIVATE FIELDS
        private bool _oxygen;
        /// <summary>
        /// This is a constractor
        /// </summary>
        /// <param name="oxygen"></param>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        public TerrestrialPlanet(bool oxygen, string name, double diameter, double mass) 
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }
      
        // PUBLIC METHODS

        public bool Habitable()
        {
            return _oxygen;
        }

        public bool HasMoons()
        {
            return (MoonCount > 0);
        }
        public override string ToString()
        {
            string result = base.ToString() + "\n Habitable: " + _oxygen;
            return result;
        }
    }
}