using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public static class CoordinateExtension
    {
        public static Coordinate Offset(Coordinate a, Coordinate b)
        {
            Coordinate moveDiff = AbsoluteDifference(a, b); 
            return a + moveDiff;
        }

        public static Coordinate AbsoluteDifference(Coordinate a, Coordinate b)
        {
            var x = Math.Abs(a.X - b.X)*2;
            var y = Math.Abs(a.Y - b.Y)*2;
            return new Coordinate(x, y);
        }
    }
}
