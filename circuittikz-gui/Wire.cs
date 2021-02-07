using System;
using System.Collections.Generic;
using System.Drawing;

namespace circuittikz_gui
{
    public class Wire : CircuitElement
    {
        public Wire(Point startCoords, Point endCoords) : base(startCoords, endCoords) { }
        public override string getTeX()
        {
            if (Q.Count == 0) // if no optional arguments, the wire is like a line
                return $"\\draw({startCoords.X},{startCoords.Y})to({endCoords.X},{endCoords.Y});";
            return $"\\draw({startCoords.X},{startCoords.Y})to[short{getOptArgs()}]({endCoords.X},{endCoords.Y});";
        }
    }
}
