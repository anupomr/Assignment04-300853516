using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Anupom Roy
 * Date: July 25, 2017
 * Description: This is the GiantPlanet class which inherits from the Planet class
 * and implements the IHasMoons, IHasRings
 * Version: 0.1 -GiantPlanet class Created.
 */
namespace Assignment04_300853516
{
    public class GiantPlanet: Planet, IHasMoons, IHasRings
    {
        private string _type;
        public GiantPlanet(string type, string name, double diameter, double mass)
            :base(name,diameter,mass)
        {
            this._type = type;
        }
        public bool HasMoons()
        {
            return (MoonCount > 0);
        }

        public bool HasRings()
        {
            return (RingCount>0);
        }
    }
}