using System;
using System.Collections.Generic;
using System.Drawing;

namespace circuittikz_gui
{
    public class Node : CircuitElement
    { 
        public Node(Point coords, string text, string location="above") : base(coords, CircuitElement.NULL)
        {
            this.text = text;
            this.location = location;
        }
        public string text { get; }
        public string location { get; }
        public override string getTeX()
        {
            return $"\\node({startCoords.X},{startCoords.Y})[{location}]{{{text}}};";
        }
        public override string getDebugInfo()
        {
            return $"location: {location} ({startCoords.X},{startCoords.Y}), text: {text}\n";
        }
    }
}
