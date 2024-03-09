using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABException
{
    internal class InvalidRadiusException:Exception
    {
        public InvalidRadiusException() : base("radius must be greater than zero.") { }
        public InvalidRadiusException(double radius) : base($"Invalid radius: {radius}. radius must be greater than zero.") { }

    }
}
