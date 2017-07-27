using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Anupom Roy
 * Date: July 25, 2017
 * Description: This is the GiantPlanet class which inherits from the Planet class
 * and implements the IHasMoons, IHasRings
 * Version: 0.2 -GiantPlanet class Modified with Comment.
 */
namespace Assignment04_300853516
{
    public class GiantPlanet: Planet, IHasMoons, IHasRings
    {
        // PRIVATE FIELDS
        private string _type;
       /// <summary>
       /// Constractor
       /// </summary>
       /// <param name="type"></param>
       /// <param name="name"></param>
       /// <param name="diameter"></param>
       /// <param name="mass"></param>
        public GiantPlanet(string type, string name, double diameter, double mass)
            :base(name,diameter,mass)
        {
            this._type = type;
        }

        // PUBLIC METHODS
        public bool HasMoons()
        {
            return (MoonCount > 0);
        }

        public bool HasRings()
        {
            return (RingCount > 0);
        }
        public override string ToString()
        {
            string result = base.ToString()+ "\n Type: "+ _type;
            return result;
        }
    }
}