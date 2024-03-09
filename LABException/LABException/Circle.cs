using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LABException
{

    internal class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius > 0)
            {
                this.radius = radius;
            }
            else
            {
                throw new InvalidRadiusException(radius);
            }
        }

        public void SetRadius(double newradius)
            {
                if (newradius > 0)
                {
                    this.radius = newradius;
                }

                else 
                {
                    throw new InvalidRadiusException(newradius);
                }
            } 

            public override string ToString()
            {
                return $"Circle's radius is {radius}";
            }
    
    }
}
