using System.Drawing;

namespace circuittikz_gui
{
    public class Resistor : CircuitElement
    {
        public Resistor(Point startCoords, Point endCoords, string resistence, string unit="", string type="R") : base(startCoords, endCoords)
        {
            R = new Quantity(type, resistence, unit);
        }
        public Quantity R { get; }
        public override string getTeX()
        {
            return $"\\draw({startCoords.X},{startCoords.Y})to[R={R.value}{getOptArgs()}]({endCoords.X},{endCoords.Y});";
        }
        public override string getDebugInfo()
        {
            return $"R={R.value}\n" + base.getDebugInfo();
        }
    }
}
